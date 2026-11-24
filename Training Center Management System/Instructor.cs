using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Center_Management_System
{
    class Instructor : Person
    {
        private string _special="";
        private int _salary;
        public int salary
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(" Error :  Your salary must be greater than  0 ");
                }
                else
                {
                    _salary = value;
                }

            }
            get { return _salary; }
        }
        public string special
        {
            set { _special = value; }
            get { return _special; }
        
        }
        public Instructor(int id, string name, string email, string phone,string special_, int salary_) : base( id,  name,  email, phone)
        
        {
            special = special_;
            salary = salary_;
        
        }
        // Display instructor information
        public override void DispalyInfo()
        {
            Console.WriteLine(" Instructor  Information : ");

            Console.WriteLine(
                "ID   : " + Id + "  " + "\n" +
                "Name :  " + Name + "  " + "\n" +
                "Email : " + Email + "  " + "\n" +
                "Phone : " + Phone + "  " + "\n" +
                "Salary : " + salary + "  " + "\n" +
                "Specialization :" +special + "  ");
        }

    }
    }


