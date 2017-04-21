using System;

namespace Calculator
{
    public class Calculator
    {
        public int Amount { get; set; }

        public void Add(int i)
        {
            Amount += i;
        }
        public void Subtract(int i)
        {
            Amount -= 1;
        }
        public void Divide(int i)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException();
            Amount /= i;
        }
    }
}
