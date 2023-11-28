using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_11_28
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            //角谷猜想
            //随便给定一个数，当这个数为偶数时让他/2，否则*3+1；
            //到后面一定会等于1
            int a;
            *//*Random rnd = new Random();
            a = rnd.Next(9) + 1;*//*
            a = 3;
            while (a!=1)
            {
                if (a % 2 == 0)
                    a /= 2;
                else
                    a = a * 3 + 1;
                Console.Write("\t"+a);
            }
        }*/

        //筛选求素数
        static void Main()
        {
            int n = 100;
            bool[] a = new bool[n + 1];
            for(int i = 2; i <= n; i++)
                a[i] = true;
            for(int i = 2; i < n; i++)
            {
                for(int j = i * 2; j <= n; j += i)//将i的倍数都给划掉
                {
                    a[j] = false;
                }
            }
            for (int i=2; i <= n; i++)
                if (a[i]) Console.Write(i + " ");
        }
    }
}
