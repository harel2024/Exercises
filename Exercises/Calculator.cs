using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Calculator
    {
        internal int Add(int x, int y) {return x + y;}

    }
    public class MathOperations
    {
        Calculator c = new Calculator();
        public void print()
        {
            Console.WriteLine(c.Add(5, 7));
        }
    }
}

