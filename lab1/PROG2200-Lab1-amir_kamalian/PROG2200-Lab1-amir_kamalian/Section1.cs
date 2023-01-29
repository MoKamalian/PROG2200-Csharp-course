
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


namespace Lab1 {

    class Section1 {
        public static void Main(String[] args)
        {
            /* reading in general survey input */ 
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born in? ");
            string birthMonth = Console.ReadLine();
            
            /* the two new questions */
            Console.WriteLine("How many children do you have? ");
            int numBirths = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("What is your marital status? ");
            string maritalStatus = Console.ReadLine(); 

            /* Outputting information given */
            Console.WriteLine($"\n------\nName: {name}\nAge: {age}\nMonth Born: {birthMonth}\nNumber of Births: {numBirths}" +
                              $"\nMarital Status: {maritalStatus}");
            
            

        }
    }

}


