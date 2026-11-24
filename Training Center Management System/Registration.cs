using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Center_Management_System
{
     class Registration
    {
        private int _registrationId;
        private Student _student;
        private Course _courseI;
        private string _registrationDate = "";
        public int registrationId {  get { return _registrationId; } set { _registrationId = value; }    }
        public Student student { get { return _student; } set { _student = value; } }
        public Course courseI { get { return _courseI; } set { _courseI = value; } }
        public string registrationDate { get { return _registrationDate; } set { _registrationDate = value; } }

      public Registration( int _registrationId , Student _student , Course _courseI , string _registrationDate) { 
        
        this.registrationId = _registrationId;
            this._student = _student;
            this._courseI = _courseI;
            this.registrationDate = _registrationDate;

        }
        // Check seat availability and registration the student in the course
        public void ConfirmRegistration() {
            if (_courseI.currentStudent < _courseI.maxStudents)
            {
                _courseI.addStudent();
                _student.AddCourse(_courseI.courseName);
                Console.WriteLine(" Registration confirmed for " + _student.Name + " in " + _courseI.courseName);
            }
            else {
                Console.WriteLine("Registration failed : Course is full .");
            
            }

            }
        public void DisplayRegistrationInfo() {

            Console.WriteLine("Registration ID : " + registrationId);
            Console.WriteLine("Date :            " + registrationDate);
            Console.WriteLine("Student :         " + _student.Name);
            Console.WriteLine("Course : "+_courseI.courseName);



        }
        
        
        
        
        
        }








    }

