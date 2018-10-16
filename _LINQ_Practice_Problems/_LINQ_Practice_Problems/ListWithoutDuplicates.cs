using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LINQ_Practice_Problems
{
    class ListWithoutDuplicates
    {
        public	List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
       
        public List<string> listOfStringsWithOutDuplicates;
        public ListWithoutDuplicates()
        {

        }
        public void Comparing()
        {
            
            listOfStringsWithOutDuplicates = RemoveDuplicatesFromStringList(names);
            
        }

        public List<string> RemoveDuplicatesFromStringList(List<string> list)
        {
            var listOfStringsWithOutDuplicates = names.Distinct().ToList();

           Console.WriteLine("Here is the new list: " + listOfStringsWithOutDuplicates.Aggregate((x, y) => x +  y) + ".\n");
            return listOfStringsWithOutDuplicates;
        }
    }
    
}
