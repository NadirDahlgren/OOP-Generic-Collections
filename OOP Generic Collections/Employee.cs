using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Generic_Collections
{
    enum Gender
    {
        Male,
        Female,
        Other
    }

    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Salary { get; set; }

        public Employee(int id, string name, Gender gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}