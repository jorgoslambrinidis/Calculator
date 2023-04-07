using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        public void Addition(double num1, double num2)
        {
            var result = num1 + num2;
            Console.WriteLine($"Operacija Sobiranje: {result}");
        }
                                          //5           //3
        public double AdditionPlus(double num1, double num2)
        {
            num1 = num1 + 1.5; // num1 += 1.5;
            var result = num1 + num2;
            return result; //9.5
        }

        public void Substruction(double num1, double num2)
        {
            // num1 -= 1.5;
            var result = num1 - num2;
            Console.WriteLine($"Operacija Odzemanje: {result}");
        }

        public void Multiplication(double num1, double num2)
        {
            var result = num1 * num2;
            Console.WriteLine($"Operacija Mnozenje: {result}");
        }

        public void Division(double num1, double num2)
        {
            var result = num1 / num2;
            Console.WriteLine($"Operacija Delenje: {result}");
        }

    }
}
