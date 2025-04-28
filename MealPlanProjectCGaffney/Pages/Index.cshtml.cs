using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MealApp.Pages
{
    public class IndexModel : PageModel
    {
        string apiKey = "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";
        [BindProperty]
        public required UserData UserInput { get; set; }

        public void OnGet()
        {
            if (TempData.ContainsKey("UserInput"))
            {
                var json = TempData["UserInput"] as string;
                if (!string.IsNullOrEmpty(json))
                {
                    UserInput = JsonConvert.DeserializeObject<UserData>(json);
                    TempData.Keep("UserInput");
                }
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            string prompt = $@"Create a 7-day healthy, simple, and affordable meal plan for an elderly person named {UserInput.Name}.
                            They like: {UserInput.Likes}
                            They dislike: {UserInput.Dislikes}
                            Allergies: {UserInput.Allergies}
                            Provide an average weekly cost of the meals provided and average amount of time needed to make each meal.";

            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "system", content = "You are a helpful meal planning assistant." },
                    new { role = "user", content = prompt }
                },
                temperature = 0.7
            };

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
            var result = await response.Content.ReadAsStringAsync();

            TempData["UserInput"] = JsonConvert.SerializeObject(UserInput);

            if (!response.IsSuccessStatusCode)
            {
                TempData["MealPlan"] = $"GPT Error: {result}";
            }
            else
            {
                dynamic jsonResponse = JsonConvert.DeserializeObject(result);
                TempData["MealPlan"] = (string)(jsonResponse?.choices[0]?.message?.content?.ToString() ?? "No meal plan generated.");
            }

            return RedirectToPage("MealPlan");
        }

    }

    public class UserData
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Likes { get; set; }
        public string? Dislikes { get; set; }
        public string? Allergies { get; set; }
        public string? MealPlan { get; set; }
    }
}
