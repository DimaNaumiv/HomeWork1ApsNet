using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework_1.Pages.My_Pages
{
    public class RandomSibolModel : PageModel
    { 
        public int Number { get; set; }
        public char Simbol { get; set; }
        public void OnGet()
        {
            Number = Random.Shared.Next(65, 123);
            if(Number >= 91 && Number < 97)
            {
                Number += 6;
            }
            Simbol = (char)Number;
        }
    }
}
