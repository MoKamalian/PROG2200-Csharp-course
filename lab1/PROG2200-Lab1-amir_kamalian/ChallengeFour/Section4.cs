
/*
 *
 * author: amir kamalian
 * date:   2O jan 2O23 
 *
 */


namespace Lab1 {


    public class SectionFour {


        public static void Main(String[] args) {


            Console.WriteLine("Please enter the number of students: ");
            UInt32 numStudents = UInt32.Parse(Console.ReadLine());

            int maxGrades = 2; 
            string[,] students = new string[numStudents, maxGrades];

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
