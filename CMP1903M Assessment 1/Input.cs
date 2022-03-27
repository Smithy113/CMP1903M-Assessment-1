using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_OOP
{
    public class Input
    {
        //Handles the text input for Assessment 1
        //string text = "nothing";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Enter your text here and enter * on a new line when complete");

            //Creates list
            List<string> textList = new List<string>();
            string endLine = Console.ReadLine();

            //Waits until user enters the specified item to end input
            while (endLine != "*")
            {
                textList.Add(endLine);
                endLine = Console.ReadLine();
            }
            string text = string.Join(" ", textList);

            //Returns variable text to where it was called
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            Console.WriteLine("Enter your text here and enter * on a new line when complete");

            //Creates list
            List<string> textList = new List<string>();
            string endLine = Console.ReadLine();

            //Waits until user enters the specified item to end input
            while (endLine != "*")
            {
                textList.Add(endLine);
                endLine = Console.ReadLine();
            }
            string text = string.Join(" ", textList);

            //Returns variable text to where it was called
            return text;
        }

    }
}
