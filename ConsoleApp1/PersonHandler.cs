using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PersonHandler
    {
        public List<Person> PersonList { get; set; }
        public PersonHandler()
        {
            PersonList = new List<Person>();
        }
    
        public void CreatePerson(string fName, string lName) 
        {
            var emp = new Person(fName, lName);
                        
            PersonList.Add(emp);

        }
        public void DisplayAll() 
        {
            
            foreach(Person person in PersonList)
            {
                Console.WriteLine($"{(PersonList.IndexOf(person))+1}){person.Name} (Date Created){person.Date}\n");
            }
        }



    }
}
