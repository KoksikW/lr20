using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lr20.Pages
{
    public class IndexModel : PageModel
    {
        public string CurrentTime { get; set; } = string.Empty;

        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToString("HH:mm:ss");
            ViewData["Message"] = "Ласкаво просимо до мого першого додатку!";
        }
    }
}
