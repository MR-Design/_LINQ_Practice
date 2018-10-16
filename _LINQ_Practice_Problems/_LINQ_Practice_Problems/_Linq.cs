using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LINQ_Practice_Problems
{
    class _Linq
    {
    

         public  void FindWords()
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
       
    }
}
