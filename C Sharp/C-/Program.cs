using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {

            //fun1("IBM");


            //fun2();

            //fun3();
            Console.ReadLine();










            /*//Time Converter
            Console.Write("Enter the time in minutes: ");
            int time = Convert.ToInt32(Console.ReadLine());
            int hours = time / 60;
            int minutes = time - (60 * hours);
            Console.WriteLine("Total time is {0} Hours and {1} minutes", hours, minutes);
            Console.ReadLine();*/
            
            
            
            /*// Cost of Carpeting
            int num1, num2;
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int costPerSquare = 50;
            int area = num1 * num2;
            int cost = costPerSquare * area; 
            Console.WriteLine("The answer by adding two numbers is: " + cost);
            Console.ReadLine();*/
        }

        static void fun1(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void fun2()
        {
            Console.Write("Please enter the hourly rate: ");
            decimal rate = Convert.ToDecimal(Console.ReadLine());
            if (rate < 7.5M || rate > 49.0M)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("Everything is fine");
            }
        }

        static void fun3()
        {
            Random randomGenerator = new Random();
            int myNumber = randomGenerator.Next(1, 11);

            Console.Write("Please enter your guess: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num < myNumber)
            {
                Console.WriteLine("Too low than " + myNumber);
            }
            else if (num > myNumber)
            {
                Console.WriteLine("Too High than " + myNumber);
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
