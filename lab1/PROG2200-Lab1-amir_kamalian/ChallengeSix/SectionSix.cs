

/*
 * author: amir kamalian
 * date:   21 jan 2O23
 * 
 */
 
 
namespace Lab1 {

    class MyCustomException : FormatException {

        private string message;

        public MyCustomException(string message) {
            this.message = message; 
        }

        public string getErrorMessage() { return this.message; }

    }
    
    class SectionFive {

        public static void Main(String[] args) {
            
            
            Console.WriteLine("Please enter the number of students: ");
            var studentsInput = Console.ReadLine();
            Int32 numStudents = 0;
            /* parsing of number of students input */ 
            try {
                if (!Int32.TryParse(studentsInput, out numStudents)) {
                    throw new MyCustomException("Not a number");
                }

            } catch (MyCustomException mce) {
                Console.WriteLine(mce.getErrorMessage());
                return; 
            }

            string[,] students = new string[numStudents, 2];

            /* ask the student name and corresponding grade */
            for(int i=0; i<numStudents; i++) {
                Console.WriteLine("Enter student name: ");
                var studentName = Console.ReadLine();
                Console.WriteLine("Enter corresponding grade: ");
                var studentGrade = Console.ReadLine();

                students[i,0] = studentName;
                students[i, 1] = studentGrade; 

            }

            /* print out the names and grades */ 
            for(int i=0; i<numStudents; i++) {

                Console.WriteLine($"Name: {students[i, 0]} | Grade: {students[i, 1]}");

            }



        }
        
    } 
 
}