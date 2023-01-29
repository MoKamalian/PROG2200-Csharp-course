/* 
 * 
 * author: amir kamalian
 * date:   20 jan 2023 
 * 
 * 
 */



namespace lab1
{
    class Section3 {

        public static void Main(String[] args)
        {
            /* count up from 1-10 and then from 10-1 and 
             do this five times */
            for(int j=0; j<5; j++) {
                for(int i=1; i<=20; i++) {
                    if(i>=10) {
                        int num = 20 - i; /* counting down when i passes 10 */
                        Console.WriteLine($"{num}");
                    } else {
                        Console.WriteLine($"{i}");
                    }
                } //end inner for loop 
            } // end outer for loop 

        }

    }


}

