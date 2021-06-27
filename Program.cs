using System;
using System.Diagnostics;

namespace PersonsEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            try
            {
                    person.FName = "";
                    person.LName = "";
                    person.Age = "";
                               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            
            Console.WriteLine("Hello World!");
        }
    }


    
}
