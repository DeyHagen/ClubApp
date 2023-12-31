﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication
{

    //This part is not usefull need to negotiate with FrontEnd to exchange color gama. Maybe enough send Enum value
    public static class CommonOutputFormat
    {
        public enum FontTheme
        {
            Default,
            Danger,
            Success
        }
        public static void ChangeFontColor(FontTheme fontTheme)
        {
            if (fontTheme == FontTheme.Danger)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (fontTheme == FontTheme.Success)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ResetColor();
            }
        }
    }
}
