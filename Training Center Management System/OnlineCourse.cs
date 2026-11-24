using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Center_Management_System
{
    class OnlineCourse : Course
    {
       private  string _platform="";
        private string _meetingLink="";

        public string meetingLink
        {
            set { _meetingLink = value; }
            get { return _meetingLink; }
        }
        public string platform
        {
            set { _platform = value; }
            get { return _platform; }
        }
        public OnlineCourse(int courseId, string courseName, double price, int maxStudents, string platform , string meetingLink)
            : base(courseId, courseName, price, maxStudents)
        {
            this.platform = platform;
            this.meetingLink = meetingLink;
        }
        // Display online course information, including platform and meeting link
        public override void DisplayCourseInfo()
        {
            Console.WriteLine(" Online Course Information : ");
     
            base.DisplayCourseInfo();
            Console.WriteLine(" [ Platform : " + platform + " , "+ " Meeting Link : " + meetingLink + " ] ");
            Console.WriteLine();
            
        }
    } 
}
