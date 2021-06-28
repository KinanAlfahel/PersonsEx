using System;

namespace PersonsEx
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        //public Person()
        //{

        //}

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Weight = weight;
            Height = height;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Age can not 0!");
                }
                age = value;
            }
        } //tilldelas ett värde större än 0.
        public string FName  //obligatorisk och får inte vara mindre än 2 tecken eller längre än
                             //10 tecken.
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First Name must be 2 - 10 characters long.");
                }
                fName = value;

            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Name must be 3 - 15 characters long.");

                }
                lName = value;
            }
        } //obligatorisk och får inte vara mindre än 3 tecken eller större än 15
          //tecken

        public double Height 
        { 
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        
        }
        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }

        }

    }
}