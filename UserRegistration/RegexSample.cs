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
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The First Name");
            ValidatingFirstName();
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Last Name");
            ValidatingLastName();
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Email Id");
            ValidatingEmailId();
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Phone Number");
            ValidatingPhoneNum();
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Password");
            ValidatingPassWord();
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
                bool result = regex.IsMatch(emailInput[i]);
                if (result)
                {
                    Console.WriteLine(emailInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(emailInput[i] + " ----->Invalid");
                }
            }

        }
        public void ValidatingPhoneNum()
        {
            string[] phoneNumInput = { "91 7852234896", " 91 9865741548", "919865795312", "91@123", "A865" };
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);
            for(int i=0;i<phoneNumInput.Length;i++)
            {
                bool result = regex.IsMatch(phoneNumInput[i]);
                if(result)
                {
                    Console.WriteLine(phoneNumInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(phoneNumInput[i] + " ----->InValid");
                }

            }
        }

        public void ValidatingPassWord()
        {
            string[] phoneNumInput = {"Radhika12","sumAthi32","Priya","praveena"};
            string passwordPattern = @"^(?=.*[A-Z]).{8,}$";
            Regex regex = new Regex(passwordPattern);
            for (int i = 0; i < phoneNumInput.Length; i++)
            {
                bool result = regex.IsMatch(phoneNumInput[i]);
                if (result)
                {
                    Console.WriteLine(phoneNumInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(phoneNumInput[i] + " ----->InValid");
                }

            }
        }
    }
}
