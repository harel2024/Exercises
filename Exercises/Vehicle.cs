using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Vehicle
    {
        protected string model;
        private protected int engineCapacity;

    }
    internal class Car : Vehicle
    {
        private int numberOfDoors;

        private void SetModel(string model)
        {
            this.model = model;
        }
        public void print()
        {
            Console.WriteLine(model,engineCapacity,numberOfDoors);
        }
    }
}
