using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models
{
    public class Suggestions
    {
        //I made all the form inputs required, with an extra validation for phone number 
        [Required]
        public string SuggestionName { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string FavDish { get; set; }
        //this is the validator to make sure its a valid phonenumber
        [Required, Phone]
        public string PhoneNumber { get; set; }



    }
}
