//Assignment #3: Control Statements

//Create a Project in your github directory named Homework3

//I will check your github account for Homework3

//Write a program that takes seconds and converts it into days, hours, minutes, and seconds.
//(Hint: Have a variable that has the number seconds per day, the number seconds per hour, and the number seconds per minute.)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create variables
            int inputSeconds;
            int secondsPerMinute = 60;
            int secondsPerHour = secondsPerMinute * 60;
            int secondsPerDay = secondsPerHour * 24;

            //Accept input value
            Console.WriteLine("How many seconds do you want to convert into DD:HH:MM:SS?");
            inputSeconds = Int32.Parse(Console.ReadLine());

            //Convert input value (in seconds) into days, hours, minutes, and seconds
            int days = inputSeconds / secondsPerDay;
            int dayRemainder = inputSeconds % secondsPerDay;
            int hours = dayRemainder / secondsPerHour;
            int hourRemainder = dayRemainder % secondsPerHour;
            int minutes = hourRemainder / secondsPerMinute;
            int minuteRemainder = hourRemainder % secondsPerMinute;
            int seconds = minuteRemainder;

            //Display output value
            Console.WriteLine("Your number of seconds converted into DD:HH:MM:SS is: {0}:{1}:{2}:{3}", days, hours, minutes, seconds);
            Console.ReadLine();

        }
    }
}
