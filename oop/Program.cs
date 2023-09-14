using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args) {

            Calculator calc = new Calculator();

            int x = 3;
            int y = 5;
            int sumAdd = 0;
            int sumSubtract = 0;
            int sumMultiply = 0;
            int sumDivide = 0;

            sumAdd = calc.Add(x, y);
            sumSubtract = calc.Subtract(x, y);
            sumMultiply = calc.Multiply(x, y);
            sumDivide = calc.Divide(x, y);

            Console.WriteLine("Sum of {0} + {1} = {2}", x, y, sumAdd);
            Console.WriteLine("Sum of {0} - {1} = {2}", x, y, sumSubtract);
            Console.WriteLine("Sum of {0} * {1} = {2}", x, y, sumMultiply);
            Console.WriteLine("Sum of {0} / {1} = {2}", x, y, sumDivide);

            Console.ReadLine();
        }
    }
}
