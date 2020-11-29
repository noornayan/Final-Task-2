using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine();
            Console.WriteLine("Basic Calculator Interface");
            Console.WriteLine();
            BasicCalc b = new BasicCalc();
            Console.WriteLine("Summation Result");

            b.sum(30, 15);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Subtraction Result");
            Console.WriteLine();
            b.sub(30, 15);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Multiplication Result");
            Console.WriteLine();
            b.multiplication(30, 15);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Division Result");
             Console.WriteLine();
            b.division(30, 15);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Scientific Calculator Interface ");
            Console.WriteLine();
            SciCal s = new SciCal();
            Console.WriteLine();
            Console.WriteLine("Division Result");
            Console.WriteLine();
            s.division(21, 3);
            Console.WriteLine("Factorial Result");
            Console.WriteLine();
            s.factorial(5);
            Console.WriteLine();
            Console.WriteLine("X to Y Result");
            Console.WriteLine();
            s.XtoY(100, 500);
        }
    }
}
