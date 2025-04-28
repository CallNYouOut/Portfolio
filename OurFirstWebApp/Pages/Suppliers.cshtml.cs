//what is this codebehind????
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;
using Microsoft.AspNetCore.Mvc;

namespace OurFirstWebApp.Pages
{
    public class SuppliersModel : PageModel
    {
        private NorthwindContext db;

        //create constructor that loads the db
        
        public SuppliersModel(NorthwindContext northwindDatabase)
        {
            db = northwindDatabase;
        }
        [BindProperty]
        public Supplier? Supplier { get; set; }

        public IEnumerable<Supplier>? Suppliers { get; set; }
        public void OnGet()
        {
            //method gets called when page is requested
            ViewData["Title"] = "CPT-206-Web Project";
            //create a suppliers array to be viewed on the page
            Suppliers = db.Suppliers.OrderBy(c=> c.Country).ThenBy(c=> c.CompanyName);
        }

        public IActionResult OnPost()
        {
            if ((Supplier is not null) && ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            else
            {
                return Page(); // return to original page
            }
        }
    }
}
