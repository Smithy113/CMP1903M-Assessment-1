//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            var input = new Input();

            //Create an 'Analyse' object
            var analyse = new Analyse();

            //Create 'Report' object
            var report = new Report();

            //Get either manually entered text, or text from a file
            Console.WriteLine("Hello User");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Do you want to enter the text via the keyboard?");
            Console.WriteLine("2. Do you want to read in the text from a file?");
            Console.WriteLine("Enter 1 or 2: ");

            //Defining varibales for the users choice and assigning them
            string textInput = "";
            string userInput = Console.ReadLine();

            //IF statement to determine what the users input is and what code to run next
            if (userInput == "1")
            {
                //Gets the user to input text manually and sets the varibale textInput to the inputted text
                textInput = input.manualTextInput();
                Console.WriteLine(textInput);
            }
            else if (userInput == "2")
            {
                //Gets user to enter location of the file to open and read text from
                Console.WriteLine("Enter the location of your file: ");
                string fileName = @"" + Console.ReadLine();

                //Sets the text from the file to the variable textInput
                textInput = input.fileTextInput(fileName);
                Console.WriteLine(textInput);

                //Runs the analyse 
                analyse.analyseLong(textInput);
            }
            else
            {
                Console.WriteLine("Please Enter a correct input");
            }

            //Pass the text input to the 'analyseTextFile' method
            //Receive a list of integers back
            parameters = analyse.analyseTextFile(textInput);
            Dictionary<char, int> dict = analyse.letterFrequency(textInput);

            //Report the results of the analysis
            report.outputConsole(parameters);
            report.reportFrequency(dict);

        }
        private static object Report()
        {
            throw new NotImplementedException();
        }

        private static object Analyse()
        {
            throw new NotImplementedException();
        }

        private static object Input()
        {
            throw new NotImplementedException();
        }

    }
}
