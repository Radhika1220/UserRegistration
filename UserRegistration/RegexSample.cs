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
            Console.WriteLine("Validating The First Name");
            ValidatingFirstName();
            Console.WriteLine("Validating The Last Name");
            ValidatingLastName();
            Console.WriteLine("Validating The Email Id");
            ValidatingEmailId();
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
        public void ValidatingLastName()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the last name : ");
            string input1 = Console.ReadLine();
            bool res1 = regex.IsMatch(input1);
            if (res1)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatingEmailId()
        {
            string[] emailInput = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com",  "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com",  "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            string emailPattern= (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
            for (int i = 0; i < emailInput.Length; i++)
            {
                Match match = regex.Match(emailInput[i]);
                if (match.Success)
                {
                    Console.WriteLine(emailInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(emailInput[i] + " ----->Invalid");
                }
            }

        }



    }
}
