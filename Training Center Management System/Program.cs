using Microsoft.Win32;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Training_Center_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineCourse o1 = new OnlineCourse(22, "C#" , 55 , 2 , " XXD" , "xxd.hj/l/556");
            OnsiteCourse o2 = new OnsiteCourse(24, "python", 76, 8, 5, "Midan_Building_number1");
            Student s1 = new Student( 1, "sidra" , "sidrarr@gmail.com" , "0987654368" , 500,"2026_11_23");
            Student s2 = new Student(2, "widad", "widadyy@gmail.com", "0965894329", 501, "2026_11_23");
            Student s3 = new Student(3, "noor", "noorty@gmail.com", "0971287632", 503, "2026_11_23");
            Registration r1 = new Registration(1 , s1 , o1,"2026_11_23");
            Registration r2 = new Registration(2, s2, o1, "2026_11_23");
            Registration r3 = new Registration(3, s3, o1, "2026_11_23");
            Instructor i1 = new Instructor(1,"Marcel" ,"marcel@gmail.com" , "0976543912","Software Engineering",444);

            // Check seat availability and registration the student in the course
            Console.WriteLine("---- 1.Display registration receipt details ------"+"\n");
            r1.ConfirmRegistration();
            r2.ConfirmRegistration();
            r3.ConfirmRegistration();
            Console.WriteLine("\n" );

            // Display onsite and online course information
            Console.WriteLine("---- 2.Display onsite and online course information ------"+"\n");
            o1.DisplayCourseInfo();
            o2.DisplayCourseInfo();
            Console.WriteLine();

            Console.WriteLine("---- 3.The number of registed students in online and onsite course ------"+"\n");
            int h1 = o1.GetRegisteredStudentsCount();
            Console.WriteLine("The number of registed students in online course :  " + h1);
            int h2 = o2.GetRegisteredStudentsCount();
            Console.WriteLine("The number of registed students in online and onsite course : "+h2+"\n");



            Console.WriteLine("---- 4.Course Statistics & Price ------"+"\n");
            Console.WriteLine("Registered Students in Online Course :  " +o1.GetRegisteredStudentsCount());
            Console.WriteLine("Total price for online Course :         "+o1.CalculateTotalPrice() +"\n");


            Console.WriteLine("---- 5.Student Information & List of courses ------ "+ "\n");
            s1.AddCourse("python");
            s1.AddCourse("java");
            s1.DispalyInfo();
            s1.PrintCourse();

            Console.WriteLine("--- 6.Display Coach information ------"+"\n");
            i1.DispalyInfo();


            // Note : There are still many other methods  in the classes that weren't used here in Program.cs _ feel free to try them out!  



        }
    }
}
