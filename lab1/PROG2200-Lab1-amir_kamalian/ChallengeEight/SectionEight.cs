

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
            
            parseDouble(test, out outDouble);
            Console.WriteLine("Result: {0}", outDouble);
            Console.WriteLine("Test type is {0}", outDouble.GetType());

            test = "Ronan";
            outDouble = 0.0;
            
            parseDouble(test, out outDouble);
            Console.WriteLine("Result: {0}", outDouble);
            Console.WriteLine("Test value is {0}", outDouble.GetType());

        }

        public static bool parseDouble(string input, out double num) {
            try {
                num = Double.Parse(input);
                Console.WriteLine(true);
                return true;
            } catch (Exception e) {
                num = 0.0;
                Console.WriteLine(false);
                return false; 
            }
        }
        
    }
 
}

