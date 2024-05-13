using System;
using System.Reflection;
using System.Reflection.Metadata;

namespace ConsoleApp2
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Boolean state = true;
            int answer = 0;

            while (state)
            {
                Console.WriteLine("Hello, what operation are you trying to do?");
                Console.WriteLine();
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");
                Console.WriteLine("------------------------");
                Console.WriteLine("5. Exit the Application");
                Console.WriteLine();

                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                } catch (Exception e) 
                {
                    answer = -1;
                    Console.WriteLine();
                }

                switch (answer)
                {
                    case 1: Addition(); break;
                    case 2: Subtraction(); break;
                    case 3: Division(); break;
                    case 4: Multiplication(); break;
                    case 5: state = false; break;
                }

                if (answer > 5 || answer < 1) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Your Input is not valid. Please try again.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            static void Addition()
            {
                double num1 = 0, num2 = 0;
                bool state1 = true, state2 = true;
   
                while (state1)
                {
                    Console.WriteLine();
                    Console.Write("What is your first number?: ");

                    try
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        num1 = double.NaN;
                    }

                    if (num1 >= 0 || num1 < 0)
                    {
                        break;
                    }
                }

                while (state2)
                {
                    Console.WriteLine();
                    Console.Write("What is your second number?: ");

                    try
                    {
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        num2 = double.NaN;
                    }

                    if (num2 >= 0 || num2 < 0)
                    {
                        break;
                    }
                }

                double result = num1 + num2;

                Console.WriteLine();
                Console.WriteLine(num1 + " + " + num2 + " = " + result);
                Console.WriteLine();
                Console.WriteLine("Click enter to continue...");

                
                Console.ReadLine();
                Console.Clear();
            }

            static void Subtraction()
            {
                double num1 = 0, num2 = 0;
                bool state1 = true, state2 = true;

                while (state1)
                {
                    Console.WriteLine();
                    Console.Write("What is your first number?: ");

                    try
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        num1 = double.NaN;
                    }

                    if (num1 >= 0 || num1 < 0)
                    {
                        break;
                    }
                }

                while (state2)
                {
                    Console.WriteLine();
                    Console.Write("What is your second number?: ");

                    try
                    {
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        num2 = double.NaN;
                    }

                    if (num2 >= 0 || num2 < 0)
                    {
                        break;
                    }
                }

                double result = num1 - num2;

                Console.WriteLine();
                Console.WriteLine(num1 + " - " + num2 + " = " + result);
                Console.WriteLine();
                Console.WriteLine("Click enter to continue...");

                Console.ReadLine();
                Console.Clear();
            }

            static void Multiplication()
            {
                double num1 = 0, num2 = 0;
                bool state1 = true, state2 = true;

                while (state1)
                {
                    Console.WriteLine();
                    Console.Write("What is your first number?: ");

                    try
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        num1 = double.NaN;
                    }

                    if (num1 >= 0 || num1 < 0)
                    {
                        break;
                    }
                }

                while (state2)
                {
                    Console.WriteLine();
                    Console.Write("What is your second number?: ");

                    try
                    {
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        num2 = double.NaN;
                    }

                    if (num2 >= 0 || num2 < 0)
                    {
                        break;
                    }
                }

                double result = num1 * num2;

                Console.WriteLine();
                Console.WriteLine(num1 + " * " + num2 + " = " + result);
                Console.WriteLine();
                Console.WriteLine("Click enter to continue...");

                Console.ReadLine();
                Console.Clear();
            }

            static void Division()
            {
                double num1 = 0, num2 = 0;
                bool state1 = true, state2 = true;

                while (state1)
                {
                    Console.WriteLine();
                    Console.Write("What is your first number?: ");

                    try
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        num1 = double.NaN;
                    }

                    if (num1 >= 0 || num1 < 0)
                    {
                        break;
                    }
                }

                while (state2)
                {
                    Console.WriteLine();
                    Console.Write("What is your second number?: ");

                    try
                    {
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        num2 = double.NaN;
                    }

                    if (num2 >= 0 || num2 < 0)
                    {
                        break;
                    }
                }

                double result = num1 / num2;

                Console.WriteLine();
                Console.WriteLine(num1 + " / " + num2 + " = " + result);
                Console.WriteLine();
                Console.WriteLine("Click enter to continue...");

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
        
