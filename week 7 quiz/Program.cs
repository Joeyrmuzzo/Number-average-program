using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_7_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            

            Console.Write("please enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Please enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("The average of " + firstNumber + " and " + secondNumber + " is: {0} ", average(firstNumber,secondNumber));
            Console.WriteLine("");

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
        public static double average(double firstNumber,double secondNumber)
        {
            double average;
            average = (firstNumber + secondNumber) / 2;
            return average;

        }
    }
}
