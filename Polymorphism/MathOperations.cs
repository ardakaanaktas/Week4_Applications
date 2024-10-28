﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class MathOperations
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double add(double a, double b)
        {
            return a + b;
        }
    }
}
