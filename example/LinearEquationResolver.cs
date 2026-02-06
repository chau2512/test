using System;
using Internal;

namespace LinearEquation
{
    class LinearEquationResolver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Give a equation: ax + b = 0, please enter:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = b / a;
                Console.WriteLine(("The solution is {0}", solution));
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("The solution is al x!:");
                }
                else
                {
                    Console.WriteLine(" No solution!");
                }
            }


        }
    }
}