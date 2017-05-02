using System;

namespace Calculator
{
    public class Calculator
    {
        public int Result { get; set; }

        public void Add(int i)
        {
            Result += i;
        }
        public void Subtract(int i)
        {
            Result -= 1;
        }
        public void Divide(int i)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException();
            Result /= i;
        }
    }
}
