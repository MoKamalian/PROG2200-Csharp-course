using System;

namespace Survey
{
    // ---------------- Modification # 1 -----------------------------------
    enum monthCategory
    {
        // Using = 0 then 1 then 2
        /*
        January = 0,
        February = 1,
        March   = 2,
        April = 3,
        May = 4
        */
        // Without Using = 0 then =1 then =2
        January,
        February,
        March,
        April,
        May
        // Continue the remaining months

    }
    // ---------------- Modification # 1 -----------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");

            /* ---------------- Modification # 3 ----------------------------------- */
            //var month = TryAnswer();
            Console.WriteLine("January : 0\nFebruary : 1\nMarch : 2\nApril : 3\nMay : 4");
            var month = int.Parse(TryAnswer()); // Integer casting (Parsing)
            monthCategory monthName = (monthCategory) month;


            /* ---------------- Modification # 3 ----------------------------------- */

            

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            /* ---------------- Modification # 4 ----------------------------------- */
            switch (month)
            {
                // Continue the previous case parts here
                case 2:
                    Console.WriteLine("You are Aries");
                    break;
                case 3:
                    Console.WriteLine("You are Taurus");
                    break;
                case 4:
                    Console.WriteLine("You are Gemini");
                    break;

                // Continue the remaining months
                default :
                    Console.WriteLine("Incorrect month number");
                    break;

            } // end of switch statement

            /* ---------------- Modification # 4 ----------------------------------- */


            // ---------------- Modification # 2 -----------------------------------
            //if (month == "march")
            //{
            //    Console.WriteLine("you are an Aries.");
            //}
            //else if (month == "april")
            //{
            //    Console.WriteLine("you are a Taurus.");
            //}
            //else if (month == "may")
            //{
            //    Console.WriteLine("you are a Gemini.");
            //}
            // ---------------- Modification # 2 -----------------------------------
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question; // It is a string datatype value
        }
    }
}
