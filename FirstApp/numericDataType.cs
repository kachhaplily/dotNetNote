using System;

namespace basic
{
    internal class numericDataType
    {
        private int age = 20;
        private double balance = 23.3;
        private long bigNumber = 4995445545454;
        decimal decimalNumber = 123.4567890123456789M;

        public numericDataType()
        {
            Console.WriteLine(age);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(balance);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.Write(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine(decimalNumber);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);


        }
    }
}
