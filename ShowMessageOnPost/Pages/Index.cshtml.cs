using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#pragma warning disable CS8618

namespace ShowMessageOnPost.Pages;
public class IndexModel : PageModel
{
    public string SuccessMessage { get; set; }

    public void OnGet(string sender)
    {
        if (sender is { })
        {
            SuccessMessage = "Finished";
        }
    }
    public Task<IActionResult> OnPostSubmit() =>
        Task.FromResult<IActionResult>(RedirectToPage("Index", new
        {
            sender = "Whatever"
        }));

    public PageResult OnPostSubmit1() => Page();
}
