using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add(19,51);
            calculator.Subtract(20,24);
            calculator.Multiply(13,12);
            calculator.Divide(200,4);

        }
    }
}
