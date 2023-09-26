using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_9_25
{
    using System;
    internal class Program
    {
        //class If_else
        //{
        //    static void Main(string[] args)
        //    {
        //        //判断成绩在哪一个档次
        //        Console.WriteLine("请输入您的成绩>");
        //        double score = double.Parse(Console.ReadLine());
        //        if (score >= 90&&score<=100)
        //            Console.WriteLine("A");
        //        else if (score >= 60&&score<90)
        //            Console.WriteLine("B");
        //        else if (score >= 0 && score < 60)
        //            Console.WriteLine("C");
        //        else
        //            Console.WriteLine("成绩不合理>");
        //    }
        //}
        //class switch_case
        //{
        //    static void Main()
        //    {
        //        //判断元辅音
        //        Console.WriteLine("请输入单个字符>");
        //        char ch = char.Parse(Console.ReadLine());
        //        if (ch >= 'a' && ch <= 'z')
        //        {
        //            //switch (ch)
        //            //{
        //            //    case 'a':
        //            //        Console.WriteLine("{0}是元音", ch);
        //            //        break;
        //            //    case 'e':
        //            //        Console.WriteLine("{0}是元音", ch);
        //            //        break;
        //            //    case 'i':
        //            //        Console.WriteLine("{0}是元音", ch);
        //            //        break;
        //            //    case 'o':
        //            //        Console.WriteLine("{0}是元音", ch);
        //            //        break;
        //            //    case 'u':
        //            //        Console.WriteLine("{0}是元音", ch);
        //            //        break;
        //            //    default:
        //            //        Console.WriteLine("{0}是辅音", ch);
        //            //        break;
        //            //}
        //            switch (ch)
        //            {
        //                case 'a':
        //                case 'e':
        //                case 'i':
        //                case 'o':
        //                case 'u':
        //                    Console.WriteLine("{0}是元音", ch);
        //                    break;
        //                default:
        //                    Console.WriteLine("{0}是辅音", ch);
        //                    break;
        //            }
        //        }
        //    }
        //}
        //class number
        //{
        //    static void Main()
        //    {
        //        //利用foreach语句计算数组中的奇数与偶数的个数
        //        int evenNum = 0, oddNum = 0;
        //        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//初始化一个一维数组
        //        foreach(int i in arr)
        //        {
        //            if (i % 2 == 0)
        //                evenNum++;
        //            else
        //                oddNum++;
        //            //Console.Write(oddNum);
        //            //Console.Write("\t");
        //            //Console.Write(evenNum);
        //            //Console.Write("\t");

        //        }
        //        Console.WriteLine("数组中共有偶数{0}个,奇数{1}个", evenNum, oddNum);
        //    }
        //}
        //class Use_goto
        //{
        //    static void Main()
        //    {
        //        int i = 0, j = 0;
        //        for (i = 1; i < 10; i++)
        //        {
        //            for (j = 1; j <= i; j++)
        //            {
        //                Console.WriteLine("{0}*{1}={2}",i,j, i * j);
        //                if (i == 5)
        //                    goto stop;//goto跳转语句(不提倡使用)
        //            }
        //            //Console.WriteLine("\n");
        //        }
        //    stop: Console.WriteLine("exit");
        //    }
        //}
        class chicken
        {
            static void Main()
            {
                //百钱买百鸡
                //某人有100元钱，要买100只鸡，公鸡五元，母鸡三元，小鸡一元3只,可以买各多少只
                double x, y, z;//公鸡，母鸡，小鸡
                for (x = 0; x <= 100; x++)
                {
                    for (y = 0; y <= 100; y++)
                    {
                        z = 100 - x - y;
                        if (x * 5 + y * 3 + z / 3 == 100)
                            Console.WriteLine("公鸡：{0}只\t母鸡：{1}只\t小鸡:{2}只",x, y, z);
                    }
                }
            }
        }
    }
}
