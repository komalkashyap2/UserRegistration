﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
      class Program
      {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Validating using Regular Expression!");
            RegexDemo regexSample = new RegexDemo();
            regexSample.Validating();
        }
      }
}
