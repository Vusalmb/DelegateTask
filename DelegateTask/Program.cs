using System;

namespace DelegateTask
{
    class Program
    {
        public delegate bool Calc(int n);
        static void Main(string[] args)
        {
            int k = 7;
            //Console.WriteLine(Sum(k,Negative));
            //Console.WriteLine(Sum(k,EvenOrOdd));
            Console.WriteLine(Sum(k, SimpleNum));
        }

        public static bool Sum(int num,Calc ins)
        {
            //if (ins(num))
            //{
            //    return true;
            //}
            //return false;

            if (ins(num))
            {
                for (var i = 2; i*i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        //public static bool Negative(int a)
        //{
        //    return a < 0;
        //}

        //public static bool EvenOrOdd(int b)
        //{
        //    return b%2==0 && b>0;
        //}

        public static bool SimpleNum(int c)
        {
            return c > 1;
        }
    }
}
