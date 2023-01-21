

/*
 * 
 * author: amir kamaian
 * date:   2O jan 2O23
 * 
 * 
 */



namespace Lab1 {
    

    class SectionFive {

        public static void Main(String[] args) {

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
                    case 1: 
                        Console.WriteLine("Capricorn");
                        break;
                    case 2:
                        Console.WriteLine("Aquarius");
                        break;
                    case 3:
                        Console.WriteLine("Pisces");
                        break;
                    case 4:
                        Console.WriteLine("Aries");
                        break;
                    case 5:
                        Console.WriteLine("Taurus");
                        break;
                    case 6:
                        Console.WriteLine("Gemini");
                        break;
                    case 7:
                        Console.WriteLine("Cancer");
                        break;
                    case 8:
                        Console.WriteLine("Leo");
                        break;
                    case 9:
                        Console.WriteLine("Virgo");
                        break;
                    case 10:
                        Console.WriteLine("Libra");
                        break;
                    case 11:
                        Console.WriteLine("Scorpio");
                        break;
                    case 12:
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