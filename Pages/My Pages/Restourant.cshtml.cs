using Homework_1.Models;
using Homework_1.Styles;
using Homework_1.StylesModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework_1.Pages.My_Pages
{
    public class RestourantModel : PageModel
    {
        public Restourant Restik {  get; set; } 
        public Restyrant_Style style { get; set; }
        public void OnGet()
        {
            Restik = new Restourant();
            style = new Restyrant_Style();
            Restik.Addres = "Syretska St, 9, Kyiv, Ukraine, 04073";
            Restik.Email = "support@puzatahata.ua";
            Restik.Name = "Пузата xата";
            Restik.PhoneNumber = "0671419951";
        }
    }
}
