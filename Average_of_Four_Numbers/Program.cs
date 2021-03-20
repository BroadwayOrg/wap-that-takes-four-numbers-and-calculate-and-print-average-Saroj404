using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_Four_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Program to Calculate Average of 4 numbers-------");
            average_four();
            Console.ReadLine();
        }

        static void average_four()
        {
            bool ok= true;
            while (ok)
            {
                try
                {
                    double first, second, third, fourth, average;
                    Console.Write("Enter first number:");
                    first = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number:");
                    second = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter third number:");
                    third = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter fouth number:");
                    fourth = Convert.ToDouble(Console.ReadLine());

                    average = (first + second + third + fourth) / 4;
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"The average of the numbers {first}, {second}, {third} and {fourth} is: {average}");
                    Console.WriteLine("------------------------------------------------------");
                }

                catch (FormatException e)
                {
                    Console.WriteLine("......Invalid input........");
                    average_four();
                }
                Console.WriteLine("Press 1 to continue || 2 to exit");
                int cont = Convert.ToInt32(Console.ReadLine());
                if(cont==1)
                {
                    ok= true;
                }
                else if(cont==2)
                {
                    ok = false;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }

            }

           

        }
    }
}
