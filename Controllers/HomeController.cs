using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //declare and instanciate new list object
            List<string> restaurantlist = new List<string>();

            //populate the list we created in the previous line
            //going to the Band.cs model to reference the GetBands method
            foreach (Top5 r in Top5.GetTop5())
            {

                //adding to the list the created string. The string pulls from the r object the name, ranking, and other information
                //"string interpolation" with the $ by saying there will be things dropped into that string
                restaurantlist.Add($"#{r.Rank}: {r.Name}. " +
                    $"Best Dish: {r.FavDish}. " +
                    $"Address: {r.Address}. " +
                    $"Phone: {r.Phone}. " +
                    $"Website: {r.Website}. ");
            }

            //pass the view the list we formatted previously
            return View(restaurantlist);
        }



        //action for loadig the Suggestions form page
        //simply loading the page, not accepting any information
        //will return the view with the same name as method
        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }


        //action for getting the restaurant information in httppost, once the button on the form is pressed
        //will return the confirmation view for when after the submit button has been pressed 
        [HttpPost]
        public IActionResult Suggestions(Suggestions suggestions)
        {
            //if the model is valid, it adds it to the TempStorage and returns the confirmation page
            if (ModelState.IsValid)
            {
                //proof that the model is linking to the form, shows up in debug window
                //Debug.WriteLine(movieResponse.Title + " has been added");
                TempStorage.AddSuggestion(suggestions);
                return View("Confirmation", suggestions);
            }

            //if the inputted data is not valid, it will return the same page, with the validation summary added
            else
            {
                return View("Suggestions");
            }

        }


        //action for loading the Restaurant SuggestionList page
        public IActionResult SuggestionList()
        {

            return View(TempStorage.Suggestions);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
