using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Training_Center_Management_System
{
    class Student : Person
    {

        public Student() { }

        private int _StudentNumber;
        private string _Regist_date="";
        public int StudentNumber
        {
            set { _StudentNumber = value; }
            get { return _StudentNumber; }
        }
        public string Regist_data {
            set { _Regist_date = value; }
            get { return _Regist_date; }
        }
        private string course = "";
        // Add a course to the student's list of courses
        public void AddCourse(string courseName)
        {
            if (course == "")
            {
                course = courseName;
            }
            else
            {
                course += ", " + courseName;
            }
        }


        public Student(int id, string name, string email, string phone, int StudentNumber, string Regist_date) : base(id, name, email, phone)
        {
            this.Regist_data = Regist_date;
            this.StudentNumber = StudentNumber;
        }
        // Display student information
        public override void DispalyInfo()
        {
            Console.WriteLine("Student  Information : ");

            Console.WriteLine(
                "1. ID : " + Id + " " + "\n" +
                "2. Name : " + Name + "  " + "\n" +
                "3. Email : " + Email + "  " + "\n" +
                "4. Phone : " + Phone + "  " + "\n" +
                "5. StudentNumber : " + StudentNumber + "  " + "\n" +
                "6. Regist_data : " + Regist_data + " \n  ");
        }
        // Print the list of courses the student is registered in
        public void PrintCourse()
        {
            if (course == "")
            {
                Console.WriteLine(" No courses registed yet.");
            }
            else
            {
                Console.WriteLine("Your courses : " + course);
                Console.WriteLine();
            }
        }
    }
}
    

