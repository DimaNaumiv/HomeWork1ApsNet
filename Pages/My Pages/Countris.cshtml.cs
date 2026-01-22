using Homework_1.Models;
using Homework_1.Styles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework_1.Pages.My_Pages
{
    public class CountrisModel : PageModel
    {
        public List<Country> Countris { get; set; }
        public Countris_Style style { get; set; }
        private void AddCountries()
        {
            Countris.Add(new Country()
            {
                Name = "Ukraine",
                Info = "Situated in Eastern Europe, it is the second-largest country on the continent by area. (Capital: Kyiv)"
            });
            Countris.Add(new Country()
            {
                Name = "Japan",
                Info = "An island nation in East Asia, located in the northwest Pacific Ocean. (Capital: Tokyo)"
            });
            Countris.Add(new Country()
            {
                Name = "Brazil",
                Info = "The largest country in both South America and Latin America. (Capital: Bras?lia)"
            });
            Countris.Add(new Country()
            {
                Name = "Canada",
                Info = "A North American country stretching from the Atlantic to the Pacific and northward into the Arctic Ocean. (Capital: Ottawa)"
            });

            Countris.Add(new Country()
            {
                Name= "Italy",
                Info = "A peninsula situated in the heart of the Mediterranean Sea in Southern Europe. (Capital: Rome)"
            });
        }
        public void OnGet()
        {
            Countris = new List<Country>();
            style = new Countris_Style();
            AddCountries();
        }
    }
}
