using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_OOP
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseTextFile(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            //5. Number of lower case letters

            //Creates list
            List<int> values = new List<int>();
            
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            //Splits the sentences from the text/entered into an array
            string[] textList = input.Split(".");
            //Calculates the number of sentences in text
            int sentences = textList.Length;
            if (sentences > 1)
            {
                sentences--;
            }

            //Replaces 0
            values.RemoveAt(0);
            values.Insert(0, sentences);

            //Sets input to lower case
            string lowerInput = input.ToLower();

            //Calculates the total number of vowels in text
            //Sets the vowelcase count to zero each time its ran
            int vowelCount = 0;
            var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};

            for (int i = 0; i < lowerInput.Length; i++)
            {
                if (vowels.Contains(lowerInput[i]))
                {
                    //Adds one to vowelCount if IF statement conditions are met
                    vowelCount++;
                }
            }

            //Replaces 0
            values.RemoveAt(1);
            values.Insert(1, vowelCount);

            //Calculates the total number of consonants in text
            //Sets the consonantcase count to zero each time its ran
            int consonantCount = 0;
            var consonant = new HashSet<char> {'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm'};

            for (int i = 0; i < lowerInput.Length; i++)
            {
                if (consonant.Contains(lowerInput[i]))
                {
                    //Adds one to constonantCount if IF statement conditions are met
                    consonantCount++;
                }
            }

            //Replaces 0
            values.RemoveAt(2);
            values.Insert(2, consonantCount);

            //Calculates total number of uppercase characters in text
            //Sets the uppercase count to zero each time its ran
            int upperCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    //Adds one to upperCount if IF statement conditions are met
                    upperCount++;
                }
            }

            //Replaces 0
            values.RemoveAt(3);
            values.Insert(3, upperCount);

            //Calculates total number of lowercase characters in text
            //Sets the lowercase count to zero each time its ran
            int lowerCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    //Adds one to lowerCount if IF statement conditions are met
                    lowerCount++;
                }
            }

            //Replaces 0
            values.RemoveAt(4);
            values.Insert(4, lowerCount);

            //Returns the variable values to where it was called
            return values;
        }

        public void analyseLong(string input)
        {
            //Creates list
            List<string> words = new List<string>();

            //Replaces punctuation with nothing
            input = input.Replace(".", "");
            input = input.Replace(",", "");
            input = input.Replace("?", "");
            input = input.Replace("!", "");

            //sets the file as file name and clears any previous data
            string fileName = @"C:\Users\User\Documents\A_UoL\Assessment 1 OOP\Long Words.txt";
            File.Delete(fileName);

            string[] wordsList = input.Split(" ");

            for (int i = 0; i < wordsList.Length; i++)
            {
                if (wordsList[i].Length > 7)
                {
                    ////Adds word to wordsList if longer than 7 characters
                    words.Add(wordsList[i]);
                    //Writes words that are longer than 7 characters to the file
                    File.WriteAllLines(fileName, words);
                }
            }
        }

        public Dictionary<char, int> letterFrequency(string input)
        {
            //Calculates the frequencies of individual letters in text
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var letter in input)
            //Reads letter, creates a count of that letter and moves on. If letter count already exists one is added to the count that is already made
            {
                if (char.IsLetter(letter))
                {
                    if (dict.ContainsKey(letter))
                        dict[letter] = dict[letter] + 1;
                    else
                        dict.Add(letter, 1);
                }
            }
            //Returns the variable dict to where it was called from
            return dict;
        }
    }
}
