
/*
 * author: amir kamalian
 * date:   21 jan 2O23
 * 
 */


namespace Lab1 {
    
    /* student inherits from member and initializes name */
    public class Student: Member, IGraduate {

        public Student(string name) : base(name) {}
        
        public void graduate() {
            Console.WriteLine("Graduated");
        }

    }

}