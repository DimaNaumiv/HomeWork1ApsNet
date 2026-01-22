using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework_1.Pages.My_Pages
{
    public class DayModel : PageModel
    {
        public int Day { get; set; }
        public void OnGet()
        {
            Day = DateTime.Now.Day;
        }
    }
}
