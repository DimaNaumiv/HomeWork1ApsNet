using Homework_1.Models;
using Homework_1.Styles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework_1.Pages.My_Pages
{
    public class RestourantsListModel : PageModel
    {
        public List<Restourant> Restks { get; set; }
        public ListRestuarants_Style style { get; set; }
        private void AddRestiks()
        {
            Restks.Add(new Restourant()
            {
                Name = "Пузата xата",
                PhoneNumber = "0671419951",
                Email = "support@puzatahata.ua",
                Addres = "Syretska St, 9, Kyiv, Ukraine, 04073"
            });
            Restks.Add(new Restourant()
            {
                Name = "Yama",
                PhoneNumber = "(098) 548 38 83",
                Email = "yamayamacorp@gmail.com",
                Addres = "м. Вінниця, вул. Київська, 29",
            });
            Restks.Add(new Restourant()
            {
                Name = "RICH",
                PhoneNumber = "+380 96 090-95-95",
                Email = "rich.restaurant.karaoke.vn@gmail.com",
                Addres = "вул. Грушевського, 30",
            });
        }
        public void OnGet()
        {
            style = new ListRestuarants_Style();
            Restks = new List<Restourant>();
            AddRestiks();
        }
    }
}
