

/*
 * 
 * author: amir kamaian
 * date:   2O jan 2O23
 * 
 * 
 */



namespace Lab1 {
    

    class SectionFive {
        
        /* data class for holding student attributes */
        class Data {
            private string name;
            private int age;
            private string month; 
            
            /* getters and setters */
            public string Name {
                get {
                    return this.name;
                }
                set {
                    this.name = value; 
                }
            }

            public int Age {
                get {
                    return this.age;
                }
                set {
                    this.age = value;
                }
            }

            public string Month {
                get {
                    return this.month;
                }
                set {
                    this.month = value; 
                }
            }
            
        }
        
        public static void Main(String[] args) {

            /* reading in general survey input */
            Data dataObj = new Data(); 
            Console.WriteLine("What is your name? ");
            dataObj.Name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            dataObj.Age = Int32.Parse(Console.ReadLine());

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
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Capricorn");
                        break;
                    case 2:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Aquarius");
                        break;
                    case 3:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Pisces");
                        break;
                    case 4:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Aries");
                        break;
                    case 5:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Taurus");
                        break;
                    case 6:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Gemini");
                        break;
                    case 7:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Cancer");
                        break;
                    case 8:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Leo");
                        break;
                    case 9:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Virgo");
                        break;
                    case 10:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Libra");
                        break;
                    case 11:
                        dataObj.Month = month.ToString();
                        Console.WriteLine("Scorpio");
                        break;
                    case 12:
                        dataObj.Month = month.ToString();
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