using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int x, y, a, b;

            // Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // Addition operator
            x = y + 2;
            // Subtraction operator
            x = y - 2;
            // Multiplication operator
            x = y * 2;
            // Division operator
            x = y / 2;
            // Order of operations using parenthesis
            x = y + 2 - b;
            // There are many operators used to evaluate values...

            // Equality operator
            if (x == 0) { }
            // Greater than operator
            if (x > 2) { }
            // Less than operator
            if (x < 3) { }
            // Greater or equal to operator
            if (x >= 4) { }

            Console.WriteLine("Hi");
        }
    }
}
