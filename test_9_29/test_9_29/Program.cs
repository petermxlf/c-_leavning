using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_9_29
{
    using System;
    using System.CodeDom;
    using System.Runtime.InteropServices;

    internal class Program
    {
        //class test
        //{
        //    static void Main(string[] args)
        //    {
        //        double[,] arr;//int型二维数组定义并初始化，动态初始化
        //        //类型[,] 数组名 = new 类型[长度1，长度2]；长度一表示第一维长度，长度2表示第二维
        //        int[,] arr1 ={ { 1,2,3,4},{ 2,3,4,5},{ 3,4,5,6} };//静态初始化

        //        //访问二维数组中的元素
        //        //int i;
        //        //int j;
        //        //for (i = 0; i < 3; i++)
        //        //{
        //        //    for (j = 0; j < 4; j++)
        //        //    {
        //        //        Console.Write(arr1[i,j]);
        //        //    }
        //        //    Console.WriteLine();
        //        //}
        //        //已知五名考生四门功课的考试成绩为
        //        arr = new double[5, 4] { 
        //            { 88, 65, 72, 64 }, 
        //            { 96, 85, 75, 92 },
        //            { 68, 63, 72, 78 }, 
        //            { 95, 89, 76, 98 }, 
        //            { 76, 65, 72, 63 } };
        //        //试求每位考生的平均成绩
        //        int i, j;
        //        for (i = 0; i < 5; i++)
        //        {
        //            double score = 0.0;
        //            for (j = 0; j < 4; j++)
        //            {
        //                score += arr[i, j];
        //            }
        //            Console.WriteLine("考生{0}的平均成绩为:{1}", i, score/4);
        //        }
        //    }
        //}
        //class sort
        //{
        //    static void Main()
        //    {
        //        //给定一组数据序列：68，65，45，79，218，112，5，16，86要求将其按照升序排列,使用冒泡排序
        //        int[] arr = new int[] { 68, 65, 45, 79, 218, 112, 5, 16, 86 };
        //        int i, j;
        //        for (i = 0; i < arr.Length; i++)
        //        {
        //            Console.Write(arr[i]+" ");
        //        }//输出待排序数列
        //        Console.WriteLine("排序后:");
        //        /*for (i =arr.Length-1; i >=0; i--)
        //        {
        //            for (j = 0; j < i; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    int ret = arr[j];
        //                    arr[j] = arr[j + 1];
        //                    arr[j + 1] = ret;
        //                }
        //            }
        //        }*/
        //        for (i = 1; i < arr.Length; i++)
        //        {
        //            for (j = 0; j < arr.Length-i; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    int ret = arr[j];
        //                    arr[j] = arr[j + 1];
        //                    arr[j + 1] = ret;
        //                }
        //            }
        //        }
        //        for (i = 0; i < arr.Length; i++)
        //        {
        //            Console.Write(arr[i] + " ");
        //        }
        //    }
        //}
        struct Student
        {
            public string name;
            public long number;//学号
            public int age;
            public static string deparment = "computer";//定义静态成员
            public long testnumber()//定义实例方法成员
            {
                return (number * 2 - 1000);
            }
        }
        struct Student1
        {
            public string name, no;//no表示学号
            public double score;//成绩
        }
        class student
        {
            //static void Main()
            //{
            //    Student stu;
            //    stu.name = "white";
            //    stu.age = 19;
            //    stu.number = 2023;
            //    Console.WriteLine("学生的个人信息如下：");
            //    Console.WriteLine("姓名{0}，年龄{1}，学号{2}，专业{3}",
            //        stu.name, stu.age, stu.number, Student.deparment);
            //    Console.WriteLine("考号：{0}", stu.testnumber());
            //}
            static void Main()
            {
                Student1[] stu=new Student1[3];
                //给定三个学生的信息并存储
                stu[0].no = "01";
                stu[0].name = "zhangsan";
                stu[0].score = 90;
                stu[1].no = "02";
                stu[1].name = "lisi";
                stu[1].score = 91;
                stu[2].no = "03";
                stu[2].name = "wangwu";
                stu[2].score = 92;
                //打印三个学生的信息
                int i = 0;
                for(i=0;i<3; i++)
                {
                    Console.WriteLine(stu[i].no + " " + stu[i].name + " " + stu[i].score);
                }
                Console.WriteLine("请输入需要差找学生的学号");
                string sn = Console.ReadLine();
                int count = 0;
                for (i = 0; i < 3; i++)
                {
                    if (sn == stu[i].no)
                    {
                        count++;
                        break;
                    }
                }
                if (count > 0)
                    Console.WriteLine(stu[i].no + " " + stu[i].name + " " + stu[i].score);
                else
                {
                    Console.WriteLine("很遗憾没有你要查找的学生");
                }
            }
        }
    }
}
