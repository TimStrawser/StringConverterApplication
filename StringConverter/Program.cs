using System;
using System.Collections.Generic;

namespace StringConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            String_Converter convert = new String_Converter();
            convert.Introduction();
        }
    }
    public class String_Converter
    {
        public string NumeralString = "";
        public void Introduction()
        {
            bool validResponse = true;
            while (validResponse)
            {
                Console.WriteLine("Do you want to convert letters to numbers? Type Y or N.  ");
                string userDecision = Console.ReadLine();
                if (userDecision == "Y" || userDecision == "y")
                {
                    Console.Write("Please enter text to be converted into integers.  ");
                    string userInput = Console.ReadLine();
                    ConvertLettersToNumbers(userInput);
                    validResponse = false;
                }
                else if (userDecision == "N" || userDecision == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Please enter Y or N when making your decision.  ");
                }
            }
        }
        public void ConvertLettersToNumbers(string userInput)
        {
            string userLetters = userInput;
            List<int> numeralList = new List<int>();
            string numeralString = "";

            foreach (char c in userLetters)
            {
                int x = (int)c;

                if (x >= 65 && x <= 96)
                {
                    x = ((x - 64) * 2);
                    numeralList.Add(x);
                }
                else if (x >= 97)
                {
                    x = x - 96;
                    numeralList.Add(x);
                }
                else
                {
                    x = -1;
                    numeralList.Add(x);
                }
            }
            foreach (int i in numeralList)
            {
                numeralString += i;
            }
            Console.WriteLine(numeralString);
            NumeralString = numeralString;

            bool validResponse = true;
            while (validResponse)
            {
                Console.WriteLine("Do you want to convert more letters? Type Y or N.");
                string userDecision = Console.ReadLine();
                if (userDecision == "Y" || userDecision == "y")
                {
                    Console.Write("Please enter text to be converted into integers.  ");
                    string userInputContinued = Console.ReadLine();
                    ConvertLettersToNumbers(userInputContinued);
                    validResponse = false;
                }
                else if (userDecision == "N" || userDecision == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Please enter Y or N when making your decision.  ");
                }
            }
        }
    }
}

