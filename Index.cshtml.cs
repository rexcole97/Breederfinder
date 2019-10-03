using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BreederFinder.Pages
{
    public class IndexModel : PageModel
    {
        // Instantiate your list of lists (arrays)
        public List<Movies> MyMovies { get; set; } = new List<Movies>();
        public string MainTitle { get; set; }
        public string[] Movies1 { get; set; }

        public void OnGet()
        {
         
            MyMovies.Add(new morphs
            {
                morphId = "1234",
                ParentSnake = "Panda Pied",
                Breeder = "Snakesandsneaks",
                style = 32.5
            });
            MyMovies.Add(new morphs
            {
                morphId = "2345",
                ParentSnake = "Blue Eyed Lucy ",
                Breeder = "Snakesandsneaks",
                style = 32.5
            });
            MyMovies.Add(new morphs
            {
                morphId = "3456",
                ParentSnake = "bumblebee",
                Breeder = "Snakesandsneaks",
                style = 95
            });

            MainTitle = "Morph this";
            morphs1 = new string[] { "Bumblebee", "Blue eyed Lucy", "Sunset",};
        }
    }
}
