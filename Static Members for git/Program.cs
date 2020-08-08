using System;

namespace Static_members_for_git
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We dont create any object from class*/
            Console.WriteLine("Our Password: "+Start.Password); // with variable
            Start.Text(); // with parameterless
            Start.Text("Mete"); // with parameter

        }
    }
}
