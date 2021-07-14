using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class RegexSample
    {
        string pattern = "^[A-Z][a-z]{2,}$";
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating The first name");
            ValidatingFirstName();
        }
        public void ValidatingFirstName()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the first name : ");
            string input = Console.ReadLine();
            bool res = regex.IsMatch(input);
            if(res)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
