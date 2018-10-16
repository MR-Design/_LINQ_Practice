using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LINQ_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //Return list that contains substrings
            List<string> wordList = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var newWordList = wordList.Where(word => word.Contains("th"));
            foreach (var word in newWordList)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //Return a copy of a list without any duplicates
            List<string> nameList = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike", };
            var newNameListNoDuplicates = nameList.GroupBy(name => name).Select(name => name.First());
            foreach (var name in newNameListNoDuplicates)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //Getting Over All Average
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            var overallAverage = classGrades.Select(grades => grades.Split(',')).Select(grades => Array.ConvertAll(grades, double.Parse)).Select(grades => (grades.Sum() - grades.Min()) / (grades.Count() - 1)).Average();

            Console.WriteLine(overallAverage);

            Console.ReadLine();


            string randomString = "TERILL";
            var letterFrequencyString = randomString.GroupBy(x => x).Select(x => x.Key + "" + x.Count()).OrderBy(x => x);

            StringBuilder newString = new StringBuilder();
            foreach (string x in letterFrequencyString)
            {
                newString.Append(x).Append("|");
            }
            Console.WriteLine(newString);
            Console.ReadLine();
=======
            _Linq link = new _Linq();
            //link.FindWords();

            link.Copy_list_without_duplicates();
>>>>>>> 36dc58f4b2443592877c3de13518aa6921004d83
        }
    }
}
