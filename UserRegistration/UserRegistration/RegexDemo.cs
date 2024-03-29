﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
      class RegexDemo
      {
        string pattern = "^[A-Za-z]{2,}$";
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating the first name");
            ValidatingFirstName();
            Console.WriteLine("Validating The Last Name");
            ValidatingLastName();
            Console.WriteLine("Validating Email Address");
            ValidatingEmailId();
            Console.WriteLine("Validating Phone Number");
            ValidatingPhoneNum();
            Console.WriteLine("Validating password");
            ValidatingPassWord();

        }
        /// <summary>
        /// UseCase1
        /// Validating first Name
        /// </summary>
        public void ValidatingFirstName()
        {
            Regex Regex = new Regex(pattern);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            bool res = Regex.IsMatch(input);
            if (res)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        /// <summary>
        /// UseCase2
        /// Validating the last name
        /// </summary>
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
        /// <summary>
        /// UseCase3
        /// Validating the Email Id
        /// </summary>
        public void ValidatingEmailId()
        {
            string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
            Console.WriteLine("Enter email Id");
            string emails = Console.ReadLine();
            bool res = regex.IsMatch(emails);
            if (res)
            {
                Console.WriteLine("valid email address");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Email!");
            }
        }
        /// <summary>
        /// UseCase4
        /// Validating Phone Number
        /// </summary>
        public void ValidatingPhoneNum()
        {
            string phoneNumPattern = @"^[1-9]\d{9}$";
            Regex regex = new Regex(phoneNumPattern);
            Console.WriteLine("Enter valid Phone Number");
            string phoneNumber = Console.ReadLine();
            bool res = regex.IsMatch(phoneNumber);
            if (res)
            {
                Console.WriteLine("valid Phone Number");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Phone Number!");
            }
        }
        /// <summary>
        /// UseCase5
        /// Validating Password
        /// </summary>

        /// <summary>
        /// For UseCase6
        /// Validating At Least Minimum 8 characters
        /// <summary>

        /// <summary>
        /// For UseCase7
        /// Validating At Least Minimum 8 characters with numeric number
        /// <summary>
        public void ValidatingPassWord()
        {
            //string passwordPattern = @"[a-z,A-Z,0-9]{8,}$";
            // string passwordPattern = @"^(?=.*[A-Z]).{8,}$";
            // string passwordPattern = @"^(?=.*\d).{8,}$";
            string passwordPattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@$!%*?&])([a-zA-Z0-9@$!%*?&]{8,})$";
           
            Regex regex = new Regex(passwordPattern);
           // Console.WriteLine("Enter password minimum 8 characters");
            Console.WriteLine("Enter password minimum 8 characters with one Special character");
            string password = Console.ReadLine();
            bool res = regex.IsMatch(password);
            if (res)
            {
                Console.WriteLine("Password valid");
            }
            else
            {
                Console.WriteLine("invalid password");
            }

        }
      }
}
