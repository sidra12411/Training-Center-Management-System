using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Center_Management_System
{
   abstract class Course
    {
        public Course (){ }
        private int _courseId;
        private string _courseName = "";
        private double _price;
        private int _maxStudents;
        private int _currentStudent;
        public int courseId { get { return _courseId; } set { _courseId = value; } }

        public string courseName { get { return _courseName; } set { _courseName = value; } }

        public double price {
            get { return _price; }
            
            set {
                if (value > 0)
                {
                    _price = value;
                }
                else { Console.WriteLine(" Invalid price. Please enter a positive value.");  }
            }
        }
        public int maxStudents {
            get { return _maxStudents; } 
            set { if (value >= 0) { _maxStudents = value; } else {Console.WriteLine(" Invalid number of students. Please enter a non-negative value."); } }
        }

        public int currentStudent { get { return _currentStudent; } private set { _currentStudent = value; } }

        public Course(int courseId, string courseName, double price, int maxStudents)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.price = price;
            this.maxStudents = maxStudents;
            this.currentStudent = 0;
        }
        public virtual void DisplayCourseInfo()
        {
           // Console.WriteLine(" Course Information : ");
            Console.WriteLine(
                "[ Course ID : " + courseId + ", "  +
                " Course Name : " + courseName + ", " +
                " Price : " + price + ", " +
                " Max Students : " + maxStudents + ", " +
                " Current Students: " + currentStudent + "] ");
        }

        // Check if the course is full or not
        public void addStudent()
        {
            if (_currentStudent < maxStudents)
            {

                _currentStudent++;
                int remainingseats = maxStudents - _currentStudent;
              
                Console.WriteLine(" Student added successfully ! Remaining seats :  " + remainingseats );
            }
            else {
                Console.WriteLine(" Sorry , the course is full! No seats available .");
            
            }


        }

        // Returns the number of registered students in the course
        public int GetRegisteredStudentsCount()
        {
            return _currentStudent;
        }

        // Calculate the total price for the course based on the number of registered students
        public virtual double CalculateTotalPrice()
        {
            return price * _currentStudent;
        }



    }
}

