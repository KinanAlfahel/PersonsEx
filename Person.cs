using System;

namespace PersonsEx
{
    public class Person
    {
        private double age;
        private string fName;
        private string lName;
        private double height;
        private double weight;


        public double Age
        {
            //do {
            get
            {
                return age;
            }

            set
            {
                if (Age == 0)
                {
                    throw new AggregateException();
                    age = value;
                }

            }

            //}
            //while (age != 0);


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
                if (FName.Length < 2 || FName.Length > 10)
                {
                    throw new ArgumentException();
                    fName = value;
                }

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
                if (LName.Length < 3 || LName.Length > 15)
                {
                    throw new ArgumentException();
                    lName = value;
                }
                
            }
        } //obligatorisk och får inte vara mindre än 3 tecken eller större än 15
          //tecken

        //public string FName { get; set; }

    }
}