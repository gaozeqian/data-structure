using System;
using System.Diagnostics;

namespace _01_复杂度
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 45;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int result1 = Fibonacci1(n);
            sw.Stop();
            Console.WriteLine($"第{n}个斐波那契数是{result1}，Fibonacci1执行时间：{sw.Elapsed}");

            sw.Restart();
            int result2 = Fibonacci2(n);
            sw.Stop();
            Console.WriteLine($"第{n}个斐波那契数是{result2}，Fibonacci2执行时间：{sw.Elapsed}");
        }

        //求第n个斐波那契数(Fibonacci number)
        //0 1 1 2 3 5 8 ...

        //时间复杂度O(2^n)
        public static int Fibonacci1(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci1(n - 1) + Fibonacci1(n - 2);
        }

        //时间复杂度O(n)
        public static int Fibonacci2(int n)
        {
            if (n <= 1)
                return n;

            int zero = 0, first = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int sum = zero + first;
                zero = first;
                first = sum;
            }
            return first;
        }

        //简化写法
        public static int Fibonacci3(int n)
        {
            if (n <= 1)
                return n;

            int zero = 0, first = 1;
            while (n-- > 1)
            {
                first += zero;
                zero = first - zero;
            }
            return first;
        }
    }
}
