using System;
using System.Diagnostics;

namespace PersonsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDo
            //Create methods to get and set Age
            //Create methods to get and set FName
            //In PersonHandler!

            var pH = new PersonHandler();
            Person newPerson = pH.CreatePerson(23, "Kalle", "Anka", 180, 80);

            pH.SetAge(newPerson, 3);
            pH.SetFName(newPerson, "Nisse");

            pH.PrintPerson(newPerson);

            //Console.WriteLine(newPerson.Age);
            //Console.WriteLine(newPerson.FName);


            // var pers = new Person();
            //Person person1 = new Person(30, "Johnas", "Anders" , 180, 80);

            //Console.WriteLine(person1.Age,
            //                  person1.FName,
            //                  person1.LName,
            //                  person1.Height,
            //                  person1.Weight);

            try
            {
                newPerson.Age = 1;
                newPerson.FName = "";
                newPerson.LName = "";
                newPerson.Height = 1;
                newPerson.Weight = 1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        Animal animal = new Animal();

    }



}
