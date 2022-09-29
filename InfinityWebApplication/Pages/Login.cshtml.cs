using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace InfinityWebApplication.Pages
{
    public class LoginModel : PageModel
    {
        public LoginModel()
        {
        }

        [BindProperty]
        public string? Password { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPostAsync()
        {
            Console.WriteLine("hi");
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Password == "correcthorsebatterystaple")
            {
                return Redirect("./financial-report?password=" + Password);
                // return Redirect("./financial-report");
            }

            return Page();
        }
    }
}