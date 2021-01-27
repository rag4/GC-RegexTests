using System;
using System.Text.RegularExpressions;

namespace Lab_7___Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateNames(GetInput("Please enter a valid NAME: ")));
            Console.WriteLine(ValidateEmails(GetInput("\nPlease enter a valid EMAIL: ")));
            Console.WriteLine(ValidatePhone(GetInput("\nPlease enter a valid PHONE NUMBER: ")));
            Console.WriteLine(ValidateDate(GetInput("\nPlease enter a valid DATE: ")));
            Console.WriteLine(ValidateHtml(GetInput("\nPlease enter a valid HTML ELEMENT: ")));

        }

        // prompt user to enter input again if not valid entry
        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            string input = "";
            while (input == null || input == "")
            {
                input = Console.ReadLine();
                if (input == null || input == "")
                {
                    Console.WriteLine("\nEmpty input. " + message);
                }
            }
            return input;
        }

        // can only have alphabets
        // should start with a capital letter
        // max length of 30
        public static bool ValidateNames(string name)
        {
            if (Regex.IsMatch(name, "^[A-Z][a-z]{0,30}"))
            {
                return true;
            }
            return false;
        }

        // combo alphanumeric characters:
        //  > length between 5 and 30
        //  > no special characters
        // @
        // combo alphanumeric characters:
        //  > length between 5 and 10
        //  > no special characters
        // .
        // combo alphanumeric characters:
        //  > length of two or three
        public static bool ValidateEmails(string email)
        {
            if (Regex.IsMatch(email, "^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}.[a-zA-Z0-9]{2,3}$"))
            {
                return true;
            }
            return false;
        }

        // 3 digits
        // -
        // 3 digits
        // -
        // 4 digits
        public static bool ValidatePhone(string number)
        {
            if (Regex.IsMatch(number, @"^\d{3}-\d{3}-\d{4}$"))
            {
                return true;
            }
            return false;
        }

        // 2 digits
        // /
        // 2 ditits
        // /
        // 4 digits
        public static bool ValidateDate(string date)
        {
            if (Regex.IsMatch(date, @"^\d{2}/\d{2}/\d{4}$"))
            {
                return true;
            }
            return false;
        }

        // validate html elements
        public static bool ValidateHtml(string html)
        {
            if (Regex.IsMatch(html, @"^<[a-z0-9]+><\/[a-z0-9]+>$"))
            {
                return true;
            }
            return false;
        }

    }
}
