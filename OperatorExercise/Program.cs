using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");


            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            Console.WriteLine($"The area of a circle with radius of {userInput} is ");
            Console.WriteLine(AreaOfCircle(radius));
            

        }

        public static double AreaOfCircle(double radius)
            {
                var area = Math.PI * Math.Pow(radius, 2);

                return area;
        }
        }
    }
