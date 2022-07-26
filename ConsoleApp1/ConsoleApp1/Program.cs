using System;

namespace Test
{
    class TestClass
    {
        public static int summ(int a, int b)
        {
            int res;
            res = a + b;
            return res;
        }
        
        public static void Main(string[] args)
        {
            int nuumber;
            nuumber = summ(4, 3);
            Console.WriteLine(nuumber);
            Console.ReadKey();

        }

    }
}