using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models
{
    public class TempStorage
    {
        //crete new list
        private static List<Suggestions> suggestions = new List<Suggestions>();

        //fill the list
        public static IEnumerable<Suggestions> Suggestions => suggestions;

        public static void AddSuggestion(Suggestions suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
