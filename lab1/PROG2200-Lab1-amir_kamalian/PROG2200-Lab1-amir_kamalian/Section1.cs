
/*
 * author: amir kamalian
 * date:   jan 19 2023
 * 
 * 
 */


/*
Challenge Questions

- What is your name?
- How old are you?
- What month were you born in?
~~additional questions~~
- What is your marital status?
- How many children do you have? 
 
 */ 


namespace Lab1
{

    class Section1 {
        public static void Main(String[] args)
        {
            /* reading in general survey input */ 
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born in? ");
            var birthMonth = Console.ReadLine();

            Console.WriteLine("How many children do you have? ");
            int numBirths = Int32.Parse(Console.ReadLine());

            /* Outputting information given */
            Console.WriteLine($"\n------\nName: {name}\nAge: {age}\nMonth Born: {birthMonth}\nNumber of Births: {numBirths}");

            

        }
    }

}


