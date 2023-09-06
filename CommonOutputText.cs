﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembershipApplication
{
    public class CommonOutputText
    {
        private static string MainHeading
        {
            get
            {
                string heading = "Cycling Club";
                return $"{heading}{Environment.NewLine}{new string ('-',heading.Length)}";
                 
            }
        }
        private static string RegistrationHeading
        {
            get
            {
                string heading = "Registered";
                return $"{heading}{Environment.NewLine}{new string('-', heading.Length)}";
            }
        }
        private static string LoginHeading
        {
            get
            {
                string heading = "Loginx`";
                return $"{heading}{Environment.NewLine}{new string('-', heading.Length)}";
            }
        }
    }
}