using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_for_git
{
    class Student:Person
    {
        public int term; 
        public int score;

        public void WriteStudent()
        {
            Console.WriteLine("Student's name: " + name + "\nStudent's age: " + age + "\nStudent's ID: " + ID + "\nStudent's term: " + term + "\nStudent's score: " + score + "\n");
        }
    }
}
