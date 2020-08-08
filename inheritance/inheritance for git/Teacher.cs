using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_for_git
{
    class Teacher:Person
    {
        public string subject; // About lesson
        public int salary; 

        public void WriteTeacher()
        {
            Console.WriteLine("Teacher's name: "+name+ "\nTeacher's age: "+age+ "\nTeacher's ID: " + ID + "\nTeacher's subject: " +subject+ "\nTeacher's salary: "+salary+"\n");
        }
    }

}
