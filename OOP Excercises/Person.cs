using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Excercises
{
    internal class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int Children { get; set; }

        public Person(int age, string fname, string lname, decimal salary, int children)
        {
            this.Age = age;
            this.FirstName = fname;
            this.LastName = lname;
            this.Salary = salary;
            this.Children = children;
        }

        public override string ToString()
        {
            return $"Name : {FirstName} {LastName} \n" +
                $"Age : {Age} \n" +
                $"Salary : {Salary} \n" +
                $"Children : {Children} ";
        }
    }
}
