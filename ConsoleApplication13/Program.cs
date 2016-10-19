using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            Car car2 = new Car(3.7, "Ford");

            Car car3 = Car.Create();

        }
    }
}
