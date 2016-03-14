using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            //Now year
            int currentYear = DateTime.Now.Year;
            // Now month
            int currentMonth = DateTime.Now.Month;
            // Now day
            int currentDay = DateTime.Now.Day;

            Console.WriteLine("Enter your Name");
            var inputName = Console.ReadLine();
            Console.WriteLine("What year were you born? (yyyy):");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born? (mm): ");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("What day were you born? (dd): ");
            var day = int.Parse(Console.ReadLine());

            ////Calculate Birthyear
            int age;
            if (currentMonth < month) age = currentYear - year - 1;
            else age = currentYear - year;




            // Calculate efter 100th birthday
            var oneHundred = new DateTime(year + 100, month, day);
            // Calculate user's next birthday. 
            var nextBirthday = new DateTime(currentYear, month, day);
            // Calculate how long until their next birthday. 
            var untilNextBirthday = nextBirthday - now;




            Console.WriteLine("Hello" + inputName);
            Console.WriteLine("You are " + ":" + age + " " + "years old, and will turn" + " " + " in " + untilNextBirthday + "days.Your 100th birthday will be on a" + " " + oneHundred + ".");


        }
    }
}
