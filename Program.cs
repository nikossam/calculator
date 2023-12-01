using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string operatoR,choice;
            bool calculator = true;

            while (calculator)
            {
                Console.WriteLine("Give the first number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give the second number: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give the operator: ");
                operatoR = Console.ReadLine();

                switch (operatoR)
                {
                    case "+":
                        Console.WriteLine(x + y);
                        Console.WriteLine("\n");
                        break;
                    case "-":
                        Console.WriteLine(x - y);
                        Console.WriteLine("\n");
                        break;
                    case "*":
                        Console.WriteLine(x * y);
                        Console.WriteLine("\n");
                        break;
                    case "/":
                        Console.WriteLine(x / y);
                        Console.WriteLine("\n");
                        break;
                }
                Console.WriteLine("Do you want to exit the app?(y/n)");
                choice = Console.ReadLine();
                if(choice == "y")
                {
                    calculator = false;
                }
                Console.WriteLine("\n");

            }
        }
    }
}
