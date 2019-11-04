using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    public abstract class Calculator : ICalculator
    {
        public abstract void some_function();

        public virtual decimal Add(decimal x, decimal y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else
                return x + y;
        }
        public decimal Substract(decimal x, decimal y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else
                return x - y;
        }

        public decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }

        public decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
            {
                return 0;
            }
            return x / y;
        }
    }
}
