using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_LAB_4
{
    class Calculator
    {
        public Calculator()
        {

        }

        private double a;
        private double b;

        //Write a Calculator class which contains a static method which divides 2 floating point numbers and returns the answer. 
        //If the second number is 0 throw an ArgumentException since division by 0 is undefined. 
        public static double DivideNumber(double a, double b)
        {
            double number = 0;
            //try
            //{
                if (b > 0)
                {
                    number = a / b;
                    Console.WriteLine("\n" + a + " / " + b + " = " + number);
                }

                else
                {
                    Console.WriteLine("Division of by", b);
                    throw new DivideByZeroException();
                }

            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Division of {0} by zero.", b);
            //}

            return number;
        }
    }
}
