

/*
 * author: amir kamalian
 * date:   21 jan 2O23
 * 
 */


namespace Lab1 {

    enum Month {
        january = 1,
        feburary,
        march,
        april,
        may,
        june,
        july,
        august,
        september,
        october,
        november,
        december
    }
    
    class SectionSeven {

        public static void Main(string[] args) {
            
            /* reading in general survey input */
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many children do you have? ");
            int numBirths = Int32.Parse(Console.ReadLine());


            /* date input and validation */
            bool isValidDate = false;
            while(!isValidDate) {

                int month;
                int day;   

                /* */ 
                Console.WriteLine("Please enter a number for the month: ");
                var monthInput = Console.ReadLine();
                if(!Int32.TryParse(monthInput, out month)) {
                    Console.WriteLine("Please enter an integer number for month..");
                    continue; 
                }
                
                /* day of the month validation */
                Console.WriteLine("Please enter a number for the day: ");
                var dayInput = Console.ReadLine();
                if(!Int32.TryParse(dayInput, out day)) {
                    Console.WriteLine("Please enter an integer number for the day..");
                    continue;
                }
                
                /* zodiac sign check and output */
                switch (month) {
                    case (int) Month.january: 
                        Console.WriteLine("Capricorn");
                        break;
                    case (int) Month.feburary:
                        Console.WriteLine("Aquarius");
                        break;
                    case (int) Month.march:
                        Console.WriteLine("Pisces");
                        break;
                    case (int) Month.april:
                        Console.WriteLine("Aries");
                        break;
                    case (int) Month.may:
                        Console.WriteLine("Taurus");
                        break;
                    case (int) Month.june:
                        Console.WriteLine("Gemini");
                        break;
                    case (int) Month.july:
                        Console.WriteLine("Cancer");
                        break;
                    case (int) Month.august:
                        Console.WriteLine("Leo");
                        break;
                    case (int) Month.september:
                        Console.WriteLine("Virgo");
                        break;
                    case (int) Month.october:
                        Console.WriteLine("Libra");
                        break;
                    case (int) Month.november:
                        Console.WriteLine("Scorpio");
                        break;
                    case (int) Month.december:
                        Console.WriteLine("Sagittarius");
                        break;
                    default:
                        Console.WriteLine("Invalid month given");
                        break;
                } /* end of switch statement */

                isValidDate = true; 

            } /* end of while loop */ 


        }
        
        
    }
 
}

