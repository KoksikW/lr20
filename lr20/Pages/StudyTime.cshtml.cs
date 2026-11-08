using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lr20.Pages
{
    public class StudyTimeModel : PageModel
    {
        [BindProperty]
        public int TotalHours { get; set; }

        [BindProperty]
        public int HoursPerWeek { get; set; }

        public string ResultMessage { get; set; } = string.Empty;

        public void OnGet() { }

        public void OnPost()
        {
            if (TotalHours <= 0 || HoursPerWeek <= 0)
            {
                ResultMessage = "Значення мають бути більшими за нуль.";
                return;
            }

            int weeks = (int)Math.Ceiling((double)TotalHours / HoursPerWeek);
            ResultMessage = $"Ви завершите курс приблизно за {weeks} тижнів";
        }
    }
}
