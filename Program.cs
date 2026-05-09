using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Calculator Progam");
            Console.WriteLine("-----------------");
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;


                Console.WriteLine("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter an option: ");

                Console.WriteLine("+ : add");
                Console.WriteLine("- : Substract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");
                Console.WriteLine("% : Modulo");

                switch (Console.ReadLine())
                {

                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {result} ");
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {result} ");
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {result} ");
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result} ");
                        break;

                    case "%":
                        result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {result} ");
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.WriteLine("Continue ? Y/N");

            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye! ");
        }
    }
}