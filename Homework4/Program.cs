//Assignment #4: Looping and Arrays

//Create a Project in your github directory named Homework4. I will check your github account for Homework4.

//The factorial of an integer n, written n!, is the product of the consecutive integers 1 through n. For example, 5 factorial
//is calculated as: 5! = 5 x 4 x 3 x 2 x 1 = 120. Write a program that allows the user to enter the number of factorials to display.
//(10 points)

//Submit a link to your github that points to your solution.For example, http://github.com/student/it-foundation/homeworkX



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accept user input of how many factorials to display
            Console.Write("Enter a number: "); 
            int totalFactorials = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            //Set initial multiplier at 1 before going into the loop
            int factorial = 1;

            //Generate requested number of factorials
            {
                for (int number = 1; number < totalFactorials + 1; number++)
                {
                    factorial = factorial * number;
                    Console.WriteLine("{0}!      =       {1}", number, factorial);
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
