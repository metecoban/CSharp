using System;
using System.Threading.Tasks.Dataflow;

namespace encapsulation_for_git
{
    class Program
    {
        static void Main(string[] args)
        {
            Person one = new Person(); // create a object
            /*
            one.name="Mete"; We can't reach like this, because we use private
            */
            one.ReachName = "Mete"; // You dont need to specify for setting 
            one.ReachAge = 20;

            Console.WriteLine(one.ReachName); // You dont need to specify for getting
            Console.WriteLine(one.ReachAge);
        }
    }
}
