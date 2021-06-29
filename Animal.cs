using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsEx
{
    public abstract class Animal
    {
        private string AnimalName { get; set; }
        private string AnimalWeight { get; set; }
        private string AnimalAge { get; set; }

        public abstract void DoSound();



        //public Stats() { } //: this(10, 10, 10, "sverige", "blue") { }
        //public override Stats(double NrOfSpikes, double IsPoisonous, double WingSpan, string pLand, string fColors, 
        //    string sGender) : base(NrOfSpikes, IsPoisonous, WingSpan, pLand, fColors, sGender)
        //{


        //}

        public virtual string Stats(double nrospikes, double ispoisonous, double wingspan, string pland, string fcolors,
            string sgender)
        {
            return $"{this.GetType().Name} has properties: {nrospikes},{ispoisonous},{wingspan},{pland},{fcolors}" +
                $",{sgender}.";
        }
        public override string Stats(double nrospikes, double ispoisonous, double wingspan, string pland, string fcolors,
            string sgender)
        {
            var result = new StringBuilder();

            result.AppendLine(base.Stats(nrospikes, ispoisonous, wingspan, pland, fcolors, sgender));

            NrOfSpikes = nrospikes;
            IsPoisonous = ispoisonous;
            WingSpan = wingspan;
            pLand = pland;
            fColors = fcolors;
            sGender = sgender;

            return result.ToString();

        }
    }

    public class Horse : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("*Horse Sounds*");
        }
    }

    public class Dog : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("*Dog Sounds*");
        }
    }
    public class Hedgehog : Animal
    {
        public double NrOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("*Hedgehog Sounds*");
        }
    }
    public class Worm : Animal
    {
        public double IsPoisonous { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("*Worm Sounds*");
        }

    }
    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("*Bird Sounds*");
        }
    }
    public class Wolf : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("*Wolf Sounds*");
        }
    }

    public class Pelican : Bird
    {
        public string pLand { get; set; }

    }

    public class Flamingo : Bird
    {
        public string fColors { get; set; }
    }

    public class Swan : Bird
    {
        public string sGender { get; set; }
    }


    public class Wolfman : Wolf
    {
        public void print(IPerson Talk)
        {

        }
    }




}
