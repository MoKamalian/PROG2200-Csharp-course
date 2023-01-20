/*
 * 
 * author: amir kamalian
 * date:   jan 19 2023
 * 
 * 
 */ 

/* passcode challenge */ 

using System;

namespace Lab1 
{
    public class Section2
    {


        public static void Main(String[] args)
        {

            string passcode = "Password123";

            Console.Write("Enter the super duper secret passcode: ");
            var input = Console.ReadLine(); 

            /* passcode verification and change */ 
            if(input == passcode)
            {
                Console.WriteLine("Congrats! You now have access to NATO nuclear triad launch code! :)");

                /* if passcode dosnt change, simply exit the program */ 
                Console.WriteLine("Would you like to change the passcode [1 = yes; 2 = no]? ");
                int choice = Int32.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    Console.WriteLine("Please enter new passcode: ");
                    passcode = Console.ReadLine();
                    Console.WriteLine("Passcode has been changed.  Goodbye :)");
                    return; 
                }


            } else {

                Console.WriteLine("No nuclear launch codes for you :(");
                return;

            } 

        }


    }
}

