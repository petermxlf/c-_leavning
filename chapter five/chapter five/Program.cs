using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_five
{
    using System;
    internal class Program
    {
        class test
        {
            //static void Main(string[] args)
            //{
            //    //int odd=0;
            //    //int even=0;
            //    //int[] arr = { 0, 1, 2, 5, 7, 8, 12, 13 };
            //    //foreach(int k in arr)
            //    //{
            //    //    if (k % 2 == 0)
            //    //        even += k;
            //    //    else
            //    //        odd += k;
            //    //}
            //    //Console.WriteLine(even);
            //    //Console.WriteLine(odd);
            //    int[,] a = new int[6, 6];
            //    a[0, 0] = 1;
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        a[i, 0] = 1;
            //        a[i, i] = 1;
            //        for (int j = 1; j < i; j++)
            //        {
            //            a[i, j] = a[i - 1, j - 1] + a[i - 1, j];
            //        }
            //    }
            //    for (int i = 0; i <= 5; i++)
            //    {
            //        for(int j = 0; j <= i; j++)
            //        {
            //            Console.Write(a[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //编写一个包含学生基本资料的结构类型数据(要求包括姓名、性别、年龄、身高、体重等)
            struct student
            {
                string name;
                string sex;
                int age;
                int height;
                double weight;
            }
            //编写程序，将一年中的12个月建立一个枚举类型数据，并进行调用
            enum moon
            {
                Jan,
                Feb,
                Mar,
                Apr,
                May,
                Jun,
                Jul,
                Aug,
                Sep,
                Oct,
                Nov,
                Dec
            }
            static void Main()
            {
                //定义一个行数和列数相等的二维数组，并初始化，计算该数组各对角线上的元素之和
                //int[,] arr = new int[4, 4] { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }, { 4, 5, 6, 7 } };
                //int i, j;
                //for(i = 0; i < 4; i++)//打印数组
                //{
                //    for (j = 0; j < 4; j++)
                //    {
                //        Console.Write(arr[i, j]+" ");
                //    }
                //    Console.WriteLine();
                //}
                //int x=0, y=0;//接收两条对角线上的元素和
                //for (i = 0; i < 4; i++)
                //{
                //    for (j = 0; j < 4; j++)
                //    {
                //        if (i == j)
                //        {
                //            x += arr[i, j];
                //        }
                //        if (i + j == 3)
                //        {
                //            y += arr[i, j];
                //        }
                //    }
                //}
                //Console.Write("x={0},y={1}",x,y);

                //建立一个一维数组，使用该数组列出所学习的课程名称
                //string[] str = new string[4] {"unity","English","mathenmatics","cumputer" };
                //for(int i = 0; i < 4; i++)
                //{
                //    Console.WriteLine(str[i]);
                //}
                    Console.WriteLine(moon.Jan);
                    Console.WriteLine(moon.Feb );
                    Console.WriteLine(moon.Mar);
                    Console.WriteLine(moon.Apr);
                    Console.WriteLine(moon.May);
                    Console.WriteLine(moon.Jun);
                    Console.WriteLine(moon.Jul);
                    Console.WriteLine(moon.Aug);
                    Console.WriteLine(moon.Sep);
                    Console.WriteLine(moon.Oct);
                    Console.WriteLine(moon.Nov);
                    Console.WriteLine(moon.Dec);
            }

        }
    }
}
