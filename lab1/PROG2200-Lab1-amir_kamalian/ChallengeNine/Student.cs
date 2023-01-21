
/*
 * author: amir kamalian
 * date:   21 jan 2O23
 * 
 */


namespace Lab1 {

    public class Student: Member, IGraduate {

        public Student(string name) : base(name) {}
        
        public void graduate() {
            Console.WriteLine("Graduated");
        }

    }

}