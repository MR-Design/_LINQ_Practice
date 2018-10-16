using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LINQ_Practice_Problems
{
    class _Linq
    {


        public void FindWords()
        {
            List<string> words = new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" };
            var Find = words.FindAll(w => w.Contains("th"));
            // var Find = words.Contains("th");
            foreach (var Found in Find)
            {
                Console.WriteLine(Found);
                Console.ReadLine();
            }

        }

        //Using LINQ, write a function that takes in a list of strings and returns 
        //a copy of the list without duplicates.
        public void Copy_list_without_duplicates()
        {
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            var Deplucated = names.Where(n=> n == n).Distinct();
            foreach (var Found in Deplucated)
            
                Console.WriteLine(Found);
                Console.ReadLine();
            
        }
    }
}
