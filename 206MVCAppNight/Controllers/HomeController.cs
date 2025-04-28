using Microsoft.AspNetCore.Authorization; // [Authorize]
using Microsoft.AspNetCore.Mvc; // Controller, IActionResult, [ResponseCache]
using _206MVCAppNight.Models; // ErrorViewMode Add client of first web api
using System.Diagnostics; // Activity
using Packt.Shared; // NorthiwindContext
using Microsoft.EntityFrameworkCore; // Include extension method
using System.Text; //Encoding

namespace _206MVCAppNight.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly NorthwindContext db;
    private readonly IHttpClientFactory clientFactory;

    public HomeController(ILogger<HomeController> logger, NorthwindContext context, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        db = context;
        clientFactory = httpClientFactory;
    }

    [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any)]
    public IActionResult Index()
    {
        _logger.LogError("This is a serious error, but not really.");
        _logger.LogWarning("This is a warning");
        _logger.LogWarning("Second Warning");
        _logger.LogInformation("I am in the Index Action Method of the HOME controller");
        //start using our model
        HomeIndexViewModel model = new
            (
            VisitorCount: (new Random()).Next(1, 1001),
            Categories: db.Categories.ToList(),
            Products: db.Products.ToList()
            );

        return View(model);
    }

    [Authorize(Roles = "Administrators")] //allows only administrators to access the privacy page
    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> Customers(string country)
    {
        string uri;
        if (string.IsNullOrEmpty(country))
        {
            ViewData["Title"] = "All Customers Worldwide";
            uri = "api/customers/";
        }
        else
        {
            // Country passed, run the call the url that passes country
            ViewData["Title"] = $"Customers in {country}";
            uri = $"api/customers/?country={country}";
        }
        HttpClient client = clientFactory.CreateClient(name: "TheFirstWebAPI");
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri);
        HttpResponseMessage response = await client.SendAsync(request);

        // enumerate and deseralize the returned json data
        IEnumerable<Customer>? model = await response.Content.ReadFromJsonAsync<IEnumerable<Customer>>();

        return View(model);
    }
    public async Task<IActionResult> Customers(string id, string country)
    {
        string uri;
        if (!string.IsNullOrEmpty(id))
        {
            ViewData["Title"] = $"Customer - {id}";
            uri = $"api/customers/{id}";
        }
        else
        {
            ViewData["Title"] = $"Customers in {country}";
            uri = $"api/customers/?country={country}";
        }
            HttpClient client = clientFactory.CreateClient(name: "TheFirstWebAPI");
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri);
        HttpResponseMessage response = await client.SendAsync(request);

        // enumerate and deseralize the returned json data
        IEnumerable<Customer>? model = await response.Content.ReadFromJsonAsync<IEnumerable<Customer>>();

        return View(model);
    }
    public IActionResult ProductDetail(int? id)
    {
        if (!id.HasValue)
        {
            return BadRequest("You must pass a product ID in the route, for example, /Home/ProductDetail/21");
        }
        Product? model = db.Products.SingleOrDefault(p => p.ProductId == id);
        if (model == null)
        {
            //did not find it
            return NotFound($"ProductId {id} not found");
        }
        return View(model);
    }
    
    public IActionResult TestModelThingBinding()
    {
        return View();
    }
    [HttpPost]
    public IActionResult TestModelThingBinding(TestModelThing thing)
    {
        return View(thing);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
