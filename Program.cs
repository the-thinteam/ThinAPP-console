﻿using System;

namespace ThinAPP
{
    class Program
    {
        static void Main()
        {
            Console.Title = "ThinAPP";
            string title = @"
 /$$$$$$$$ /$$       /$$            /$$$$$$  /$$$$$$$  /$$$$$$$ 
|__  $$__/| $$      |__/           /$$__  $$| $$__  $$| $$__  $$
   | $$   | $$$$$$$  /$$ /$$$$$$$ | $$  \ $$| $$  \ $$| $$  \ $$
   | $$   | $$__  $$| $$| $$__  $$| $$$$$$$$| $$$$$$$/| $$$$$$$/
   | $$   | $$  \ $$| $$| $$  \ $$| $$__  $$| $$____/ | $$____/ 
   | $$   | $$  | $$| $$| $$  | $$| $$  | $$| $$      | $$      
   | $$   | $$  | $$| $$| $$  | $$| $$  | $$| $$      | $$      
   |__/   |__/  |__/|__/|__/  |__/|__/  |__/|__/      |__/                                                                                                                               
                      
                                                                 ";

            Console.WriteLine(title);
            Console.WriteLine("Press any key to quit.");
            Console.Read();
        }
    }
}