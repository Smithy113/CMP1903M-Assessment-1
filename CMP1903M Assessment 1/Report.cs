using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_OOP
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public void outputConsole(List<int> input)
        {
            //Outputs all required variables that have been measured from text
            Console.WriteLine("The number of Sentences: {0}", input[0]);
            Console.WriteLine("The number of Vowels: {0}", input[1]);
            Console.WriteLine("The number of Consonants: {0}", input[2]);
            Console.WriteLine("The total number of letters: {0}", (input[1] + input[2]));
            Console.WriteLine("The number of Upper Case Letters: {0}", input[3]);
            Console.WriteLine("The number of Lower Case Letters: {0}", input[4]);
        }

        public void reportFrequency(Dictionary<char, int> dict)
        {
            foreach (var pair in dict)
            {
                //Outputs frequency of individual letters
                Console.WriteLine("There are {0} {1}'s", pair.Value, pair.Key);
            }
        }

    }
}
