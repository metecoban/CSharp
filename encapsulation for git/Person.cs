using System;
using System.Collections.Generic;
using System.Text;

namespace encapsulation_for_git
{
    class Person
    {
        private string name; // We can't reach directly.
        private int age; // We can't reach directly.

        public string ReachName // indirect access about name
        {
            get
            {
                return name; 
            }
            set
            {
                name = value; 
            }
        }
        public int ReachAge // indirect access about age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
