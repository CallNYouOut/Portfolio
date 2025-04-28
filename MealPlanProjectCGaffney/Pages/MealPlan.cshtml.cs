using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MealApp.Pages
{
    public class MealPlanModel : PageModel
    {
        public string MealPlan { get; set; }

        public IActionResult OnGet()
        {
            MealPlan = TempData["MealPlan"] as string;

            if (TempData.ContainsKey("UserInput"))
            {
                TempData.Keep("UserInput");
            }

            return Page();
        }
    }
}
