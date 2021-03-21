﻿using System;

namespace PracticeCSharp
{

    class CalculatorBrain
    {
        public double Addition(double num1,double num2)
        {
            return (num1 + num2);
        }

        public double Subtraction(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Division(double num1, double num2)
        {
            return (num1/num2);
        }
        public void DisplayResult(double num1)
        {
            Console.Write("Result = ");
            Console.WriteLine(num1);
        }

    }

    
    class Calculation
    {
        static void Main(string[] args)
        {
            CalculatorBrain calci = new CalculatorBrain();

            Console.WriteLine("--------------Menual------------------ \nStep 1.Enter First Number. \nStep 2.Enter Operator.\nStep 3.Enter Second Number\n  Table of Operators \n\t+ = Additiion\n\t- = Subtraction\n\t* =  Multiply\n\t/ = Division\n  Press Q to Quit");
            double num1 = Convert.ToDouble(Console.ReadLine());
            string Operator = Console.ReadLine();
            while (Operator != "Q")
            {
                double num2 = Convert.ToDouble(Console.ReadLine());
                switch (Operator)
                {
                    case "+":
                        num1 = calci.Addition(num1, num2);
                        calci.DisplayResult(num1);
                        break;

                    case "-":
                        num1 = calci.Subtraction(num1, num2);
                        calci.DisplayResult(num1);
                        break;

                    case "/":
                        num1 = calci.Division(num1, num2);
                        calci.DisplayResult(num1);
                        break;

                    case "*":
                        num1 = calci.Multiply(num1, num2);
                        calci.DisplayResult(num1);
                        break;

                    default: Console.WriteLine("Invalid Operator or Number");
                        break;   
                }
                 Operator = Console.ReadLine();

            }
        }
    }
}
