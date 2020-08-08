using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_for_git
{
    class Operation
    {
        public int count;
        public int count2;
        public float count3;
        public float Control(int first, float second) // Overloading  => The variable type returned is important like float.
        {
            return first + second;
        }

        public int Control(int first,int second) // Overloading  => The variable type returned is important like int.
        {
            return first + second;
        }

        public void Control() // Overloading  
        {
            // empty
        }
    }
}
