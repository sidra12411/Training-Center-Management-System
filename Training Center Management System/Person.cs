using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using Training_Center_Management_System;

namespace Training_Center_Management_System
{
    abstract class Person
    {
        public Person() { }

        private int _id;
        private string _name="";
        private string _email="";
        private string _phone="";

 public string Phone
{
    set { _phone = value; }
    get { return _phone; }

}
public int Id
{
    get { return _id; }
    set { _id = value; }

}
public string Name
{
    get { return _name; }
    set { _name = value; }

}
public string Email
{
    get { return _email; }
    set { _email = value; }

}
protected Person(int id, string name, string email, string phone)
{

    Id = id;
    Name = name;
    Email = email;
    Phone = phone;

}
public abstract void DispalyInfo();
public void PrintInfo()
{

    Console.WriteLine(" Person [ ID   : " + Id + " ] " + "[ Name :  " + Name + " ] " + "[ Email :" + Email + " ] " + "[ Phone : " + Phone + " ] ");
}
    
}
    
}
