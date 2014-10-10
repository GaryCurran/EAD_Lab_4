using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_LAB_4
{
    public class Calculator
    {
        public Calculator()
        {

        }
        //Write a Calculator class which contains a static method which divides 2 floating point numbers and returns the answer. 
        //If the second number is 0 throw an ArgumentException since division by 0 is undefined. 
        public static double DivideNumber(double a, double b)
        {
          
            if (b == 0)
            {
                throw new ArgumentException("Error occured: attempt to divide " +
                    a + " by 0");
            }
            else
            { 
                return a/b;
            }

        }
    }
}
