using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lr20.Pages
{
    public class TemperatureModel : PageModel
    {
        [BindProperty]
        public string CelsiusInput { get; set; } = string.Empty;

        public string ResultMessage { get; set; } = string.Empty;

        public void OnGet() { }

        public void OnPost()
        {
            string normalized = CelsiusInput.Replace(',', '.');

            if (double.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out double c))
            {
                double f = c * 1.8 + 32; // формула з завдання
                ResultMessage = $"{c.ToString(CultureInfo.InvariantCulture)} °C = {f.ToString("0.##", CultureInfo.InvariantCulture)} °F";
            }
            else
            {
                ResultMessage = "Введіть коректне число.";
            }
        }
    }
}
