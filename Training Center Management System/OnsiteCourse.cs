using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Training_Center_Management_System
{
     class OnsiteCourse : Course
    {
        private int _roomNumber;
        private string _location = "";
        public int roomNumber { set { _roomNumber = value; } get { return _roomNumber; } }
        public string location { set { _location = value; } get { return _location; } }
        public OnsiteCourse(int courseId, string courseName, double price, int maxStudents,int _roomNuber , string _location ) : base(courseId, courseName, price, maxStudents)
        { 
         this._roomNumber = maxStudents;
         this._location = location;

        }
        public override void DisplayCourseInfo()
        {
          
            Console.WriteLine(" Onsite Course Information : ");
    
            base.DisplayCourseInfo();
            

            Console.WriteLine("[ Location  : " + location + " ] " + "[ RoomNuber  : " + roomNumber + " ] ");
        }
    }
}
