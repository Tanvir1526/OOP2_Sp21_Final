using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            /********************** Student*********************/
            var s = new Student("1111", "Tanvir", 3.84F);
            var s1 = new Student("2222", "Ahmed", 3.56F);
            var s2 = new Student("3333", "Sohag", 3.72F);
            var s3 = new Student("4444", "Talha", 3.43F);
            var s4 = new Student("5555", "Hossain", 3.54F);
           


            /*********************** Course*********************/

            var c = new Course("C000", "OOP1");
            var c1 = new Course("C111", "OOP2");
            var c2 = new Course("C222", "DataStructure");


            /******************** Operation***********************/

            c.AddStudent(s, s1, s2, s3, s4);

            c.PrintStudent();

            c.RemoveStudent(s3);

            Console.WriteLine("\n=========  After Remove Student  ======\n");

            s4.PrintCourse();
            c.PrintStudent();

            s2.AddCourse(c, c1, c2);
            s2.PrintCourse();

            s2.RemoveCourse(c1);
            Console.WriteLine("\n=========  After Remove Course  ======\n");
            s2.PrintCourse();
            c1.PrintStudent();
        }
    }
}
