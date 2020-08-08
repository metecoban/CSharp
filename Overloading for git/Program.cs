using System;
using System.Threading;

namespace Overloading_for_git
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation one = new Operation();
            Console.Write("Int: ");
            one.count = int.Parse(Console.ReadLine()); 
            Console.Write("Int: ");
            one.count2 = int.Parse(Console.ReadLine()); 
            Console.Write("Float: ");
            one.count3 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("\nSum of int and int: " + one.Control( one.count, one.count2)); // We called same method: Control 
            Console.WriteLine("Sum of int and float: " + one.Control( one.count, one.count3)); // We called same method: Control 
        }
    }
}
