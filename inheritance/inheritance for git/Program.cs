using System;

namespace inheritance_for_git
{
    class Program
    {
        static void Main(string[] args)
        {
            Student one = new Student(); // Student object
            one.name = "Mete";
            one.age = 20;
            one.ID = 181805008;
            one.term = 5;
            one.score = 4;
            one.WriteStudent();

            Teacher first = new Teacher(); // Teacher object
            first.name = "Ali";
            first.age = 40;
            first.ID = 1554231;
            first.subject = "Science";
            first.salary = 4652;
            first.WriteTeacher();
        }
    }
}
