

/*
 * author: amir kamalian
 * date:   21 jan 2O23
 * 
 */


namespace Lab1 {

    class SectionEight {

        public static void Main(string[] args) {

            var test = "1.5";
            var outDouble = 0.0; 
            
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());

            test = "Ronan";
            outDouble = 0.0;
            
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test value is {0}", outDouble);

        }

        public static double parseDouble(string input, out double num) {
            try {
                num = Double.Parse(input);
            } catch (Exception e) {
                return num = 0;
            }

            return num; 
        }
        
    }
 
}

