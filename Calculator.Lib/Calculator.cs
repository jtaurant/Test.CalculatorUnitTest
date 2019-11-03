using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Add (int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else
                return x + y;
        }
    }
}
