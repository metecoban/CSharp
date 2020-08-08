using System;
using System.Collections.Generic;
using System.Text;

namespace Static_members_for_git
{
    class Start
    {
        public static int Password=1515; // Static memmer

        public static void Text() // Static memmer
        {
            Console.WriteLine("Welcome to program!");
        }
        public static void Text(string name) // Static memmer
        {
            Console.WriteLine("Hi "+name+", Welcome to program!");
        }

    }
}
