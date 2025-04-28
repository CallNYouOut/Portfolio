using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Packt.Shared;
namespace OurFirstWebApp.Pages
{
    public class EmployeesModel : PageModel
    {
        private NorthwindContext context;
        public EmployeesModel(NorthwindContext dbContext)
        {
            context = dbContext;
        }
        public Employee[] Employees { get; set; } = null;
        public void OnGet()
        {
            //set title
            ViewData["Title"] = "CPT-206-Web Project";
            //populates the employees array with data from the db using lambdas
            Employees=context.Employees.OrderBy(e=> e.LastName).ThenBy(e=> e.FirstName).ToArray();

        }
    }
}
