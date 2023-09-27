using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_fore
{
    using System;
    internal class Program
    {
        class practise
        {
            static void Main(string[] args)
            {
                //int i, j, k;
                //for (i = 1; i <= 8; i++)
                //{
                //    for (j = 1; j < i + 5; j++)
                //    {
                //        Console.Write(" ");
                //        for (k = 1; k <= 18 - i; k++)
                //        {
                //            Console.Write(" * ");
                //            Console.WriteLine();
                //        }
                //    }
                //}
                //编程输出1-100中能被3整除但不能被5整除的数，并统计有多少个这样的数
                //int count = 0;
                //int i = 0;
                //for (i = 1; i <= 100; i++)
                //{
                //    if (i%3 == 0 && i%5 != 0)
                //    {
                //        Console.WriteLine(i);
                //        count++;
                //    }
                //}
                //Console.WriteLine(count);
                //编程输出1000以内的所有素数
                int i = 2;
                int j = 0;
                int count = 0;
                for (i = 2; i < 1000; i++)
                {
                    if (i % 2 == 0)
                        continue;
                        for (j = 3; j < 8; j++)
                        {
                        if (i > j)
                        {
                            if (i % j == 0)
                                break;
                        }
                            if (j == 7)
                        {
                            Console.Write("{0} ", i);
                            count++;
                        }
                    }
                }
                //编写一个程序，对输入的四个整数，求出其中的最大值和最小值
                //Console.WriteLine("请输入四个整数");
                //int[] arr = { 0,0,0,0};
                //int i = 0;
                //while (i < 4)
                //{
                //    arr[i] = int.Parse(Console.ReadLine());
                //    i++;
                //}
                //int max = 0;
                //int min = 0;
                //i = 0;
                //min = arr[0];
                //for (i = 0; i < 4; i++)
                //{
                //    if (max < arr[i])
                //        max = arr[i];
                //    if (min > arr[i])
                //        min = arr[i];
                //}
                //Console.WriteLine("max={0}  min={1}",max,min);

                //分别用for/while/do-while语句编写程序，求前n个自然数之和
                //Console.WriteLine("求前n项和，请输入“n“");c
                //int n = int.Parse(Console.ReadLine());
                //int i = 0;
                //int count = 0;
                ////for(i = 1; i <= n; i++)
                ////{
                ////    count += i;
                ////}
                ////while (i<=n)
                ////{
                ////    count += i++;
                ////}
                //do
                //{
                //    count += i++;
                //} while (i<=n);
                //Console.WriteLine(count);

                //编程；输出九九乘法表
                //int i = 0;
                //int j = 0;
                //for (i = 1; i < 10; i++)
                //{
                //    for (j = 1; j <= i; j++)
                //    {
                //        Console.Write("{0}*{1}={2}\t", j, i, j * i);
                //    }
                //    Console.WriteLine();
                //}
            }
        }
        
    }
}
