using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Calculator:ICalculator
    {
        public void Add(double num1, double num2)
        {
            Console.WriteLine($"Add result is {num1 + num2}");     
        }

        public void Subtract(double num1, double num2)
        {
            Console.WriteLine($"substract result is {num1 - num2}");  
        }

        public void Multiply(double num1, double num2)
        {
            Console.WriteLine($"Multiply result is {num1*num2}");
        }

        public void Divide(double num1, double num2)
        {
            Console.WriteLine($"Divide result is {num1/num2}");   
        }
    }
}
