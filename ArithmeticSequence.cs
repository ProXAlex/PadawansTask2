using System;
using System.Runtime.CompilerServices;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if(count < 0)
                throw new ArgumentException("Count cannot be less zero");


            int result = 0;
            if (count == 0)
                return result;
            checked
            {
                result = number + add * (count - 1);
            }
            
            return result + Calculate(number, add, count - 1);

        }

    }
}
