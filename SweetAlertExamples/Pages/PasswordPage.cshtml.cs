using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace SweetAlertExamples.Pages
{
    public class PasswordPageModel : PageModel
    {
        [BindProperty]
        public string? Password { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (string.IsNullOrWhiteSpace(Password))
            {
                Log.Warning("No password entered");
            }
            else
            {
                Log.Information("Password: {P1}", Password);
            }
            
        }
    }
}
