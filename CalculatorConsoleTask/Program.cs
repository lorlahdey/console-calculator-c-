using System;
using CalculatorClassLibrary;

// using System.Collections.Generic;

namespace CalculatorConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();


            System.Console.WriteLine("\nThis is a Simple Console Calculator");
            Console.WriteLine("Please enter an operand (+, -, /, *, ^) for an action to be performed: ");
            calc.Operand = Console.ReadLine();

            switch (calc.Operand)
            {
                case "+":
                    {
                        // System.Console.WriteLine(calc.Addition());
                        // when the method type is void
                        calc.Addition();
                        break;
                    }
                case "-":
                    {
                        calc.Subtraction();
                        break;
                    }
                case "*":
                    {
                        calc.Multiplication();
                        break;
                    }
                case "/":
                    {
                        calc.Division();
                        break;
                    }
                case "^":
                    {
                        calc.SquareNum();
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! Please try again");
                    break;
            }


            // *****************************************
            // displaying the output of all calculation performed in a list

            // List<Calculator> calculate = new List<Calculator>();
            // Calculator calc1 = new Calculator
            // {
            //     Addition(),
            //     // total = 9
            // };
            // Calculator calc2 = new Calculator
            // {
            //     total = 5
            // };

            // // adding of items to the list
            // calculate.Add(calc1);
            // calculate.Add(calc2);

            // foreach (var item in calculate)
            // {
            //     // this will dispalay the list
            //     System.Console.WriteLine(item);

            // }



        }
    }
}

