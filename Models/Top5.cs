using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models
{
    public class Top5
    {
        //this constructor makes it so that you cannot change the band ranking once it is called. This is necessary becasue the BandRanking attribute does not have a set method
        public Top5(int rank, string name, string address)
        {
            Rank = rank;
            Name = name;
            Address = address;
        }

        //we remove the set; method from some of the attributes that are required! and to ones that should be read only (like rank).
        //Rank, name, and address are passed into the constructor and cannot be changed later.

        //the question mark on FavDish and Website makes this attribute possible to be null, and has values to input if the attribute is null
        public int Rank { get; }
        public string Name { get; }
        public string? FavDish { get; set; } = "It's all tasty!";
        public string Address { get; }
        public string Phone { get; set; }
        public string? Website { get; set; } = "Coming Soon!";


        //method to create the restaurants to prepopulate the list
        public static Top5[] GetTop5()
        {
            Top5 r1 = new Top5(1, "Itto Sushi", "547 E University Pkwy, Orem, UT 84097")
            {
                //commented out becasue they are created in constructor
                //Rank = 1,
                //Name = "Itto Sushi",
                FavDish = "Salmon teriyaki",
                //Address = "547 E University Pkwy, Orem, UT 84097",
                Phone = "(385) 497-7045",
                //comment out to check if it can be null
                Website = "https://ittoutah.com/menu/"


            };

            Top5 r2 = new Top5(2, "Asa Ramen", "1120 State St, Orem, UT 84097")
            {
                //Rank = 2,
                //Name = "Asa Ramen",
                FavDish = "Miso Ramen",
                //Address = "1120 State St, Orem, UT 84097",
                Phone = "(801) 842-1898",
                //not the coreect website
                Website = "https://www.menupix.com/provo/restaurants/29064926/Asa-Ramen-Orem-UT"

            };

            Top5 r3 = new Top5(3, "Guru's Cafe", "45 E Center St, Provo, UT 84606")
            {
                //Rank = 3,
                //Name = "Guru's Cafe",
                FavDish = "Chicken Caesar Salad Wraps",
                //Address = "45 E Center St, Provo, UT 84606",
                Phone = "(801) 375-4878",
                Website = "https://guruscafe.com/"

            };



            Top5 r4 = new Top5(4, "Mozz", "145 N University Ave, Provo, UT 84601")
            {
                //Rank = 4,
                //Name = "Mozz",
                FavDish = "Pepperoni Pizza",
                //Address = "145 N University Ave, Provo, UT 84601",
                Phone = "(801) 852-0069",
                //not the coreect website
                Website = "https://www.mozzartisanpizza.com/"

            };

            Top5 r5 = new Top5(5, "Waffle Love", "1831 N State St, Provo, UT 84604")
            {
                //Rank = 5,
                //Name = "Waffle Love",
                FavDish = "Nutella Waffle",
                //Address = "1831 N State St, Provo, UT 84604",
                Phone = "(801) 923-3588",
                Website = "http://www.waffluv.com/"

            };





            //pass restaurant list
            return new Top5[] { r1, r2, r3, r4, r5 };
        }
    }
}
