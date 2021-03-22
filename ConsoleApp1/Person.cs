using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name => FirstName + " " + LastName;
        public int Salary { get; set; }
        public DateTime Date { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Date = DateTime.Now;
        }
        /*public void WriteDateCreated()
        {
            Console.WriteLine(Date.ToString());
        }

        public void WritePersonName()
        {
            Console.WriteLine(Name);
        }

        public override string ToString()
        {
            return "Person" + Name + " " + Date;
            //public override string ToString() {
            // }

        }*/

    }
}