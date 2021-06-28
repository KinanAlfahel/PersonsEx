using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsEx
{
    class PersonHandler 
    {
        public void SetAge(Person person, int age) 
        {
            person.Age = age;
            //throw new NotImplementedException();
        }

        internal void SetFName(Person person, string fName)
        {
            person.FName = fName;
            //throw new NotImplementedException();
        }

        internal void SetLName(Person person, string lName)
        {
            person.LName = lName;
            //throw new NotImplementedException();
        }
        internal void SetHeight(Person person, double height)
        {
            person.Height = height;
            //throw new NotImplementedException();
        }

        internal void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
            throw new NotImplementedException();
        }

        public Person CreatePerson(int age, string fname,string lname, double height, double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

            return person;
        }
        
        public void PrintPerson (Person newPerson)
        {
            Console.WriteLine($"Age: {newPerson.Age}, Name: {newPerson.FName} { newPerson.LName} , " +
                $"Height: { newPerson.Height}, Weight: { newPerson.Weight}");

        }

}
}
