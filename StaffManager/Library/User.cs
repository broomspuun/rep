using System;

namespace Library
{
    public class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Salary { get; set; }
        public string NameOfPosition { get; set; }

        public User(string name, string surName, int salary, string Position)
        {
            Name = name.Trim();
            SurName = surName.Trim();
            NameOfPosition = Position.Trim();
            Salary = salary;
        }
    }
}
