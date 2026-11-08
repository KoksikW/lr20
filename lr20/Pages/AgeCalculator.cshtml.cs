using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lr20.Pages
{
    public class AgeCalculatorModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; } = string.Empty;

        [BindProperty]
        public int BirthYear { get; set; }

        public string ResultMessage { get; set; } = string.Empty;

        public void OnGet()
        {
            ResultMessage = "";
        }

        public void OnPost()
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - BirthYear;

            ResultMessage = $"Привіт, {UserName}! Тобі приблизно {age} років.";
        }
    }
}
