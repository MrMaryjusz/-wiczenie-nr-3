using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        public Car()
        {
            pojemnoscSilnika = 4.8;
            marka = "Skoda";
        }
        public Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }
        static public Car Create()
        {
            return new Car();

        }
        static int iloscKol;
        static Car()
        {
            iloscKol = 4;
        }
        ~Car()
        {
          Console.WriteLine("Zwalniam pamięć");
          Console.ReadKey();
        }

    }
}
