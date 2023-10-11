using System;
//using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test_10_11
{
    internal class Program
    {
        //public class Point
        //{
        //    int x, y;
        //    static void Main()
        //    {
        //        Point p = new Point();
        //        p.x = 10;
        //        Console.Write(p.x);
        //    }
        //}
        //class Point
        //{
        //    int x, y;
        //    public Point(int x, int y)
        //    {
        //        if (x < 0 || y < 0)
        //        {
        //            throw new Exception("x or y < 0");
        //        }
        //        this.x = x;
        //        this.y = y;
        //    }
        //}
        //class Test {
        //    public int x;
        //    public Test()
        //    {
        //        x = 0;
        //    }
        //    public Test(int i)
        //    {
        //        x = i;
        //    }
        //}
        //class test
        //{
        //    static void Main()
        //    {
        //        Test T0 = new Test();
        //        Console.WriteLine(T0.x);
        //        Test T1 = new Test(6);
        //        Console.WriteLine(T1.x);
        //        Test T2 = new Test(3*3);
        //        Console.WriteLine(T2.x);
        //    }
            
        //}
        //class Point
        //{
        //    int x, y, z;
        //    private Point()
        //    {
        //        this.z = 0;
        //    }
        //    private Point(int x,int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //        this.z = x + y;
        //    }
        //    ~Point()
        //    {
        //        Console.WriteLine("~Point is being called");
        //    }
        //    public static Point creatPoint()
        //    {
        //        Point p = new Point();
        //        p.x = 0;
        //        p.y = 0;
        //        return p;
        //    }
        //    public static void Main()
        //    {
        //        Point p1 = new Point(1, 2);
        //        Point p2 = Point.creatPoint();
        //        Console.WriteLine(p1.z);
        //        Console.WriteLine(p2.z);
        //    }
        //}
        //修饰符 返回值类型 方法名（形式参数列表）{方法语句}
        //class Test
        //{
        //    public void myTesh()//定义方法
        //    {
        //        int i = 0;
        //        for (i = 0; i < 10; i++)
        //        {
        //            if (i % 3 == 0)
        //                continue;
        //            Console.Write(i + " ");
        //        }
        //    }
        //    static void Main()
        //    {
        //        Test lei = new Test();
        //        lei.myTesh();
        //    }
        //}
        //class Test
        //{
        //    public int myMesh()
        //    {
        //        int j = 8;
        //        if (j > 5)
        //        {
        //            j *= 2;
        //            //Console.WriteLine(j);
        //            return j;
        //        }
        //        else
        //        {
        //            j *= 3;
        //            //Console.WriteLine(j);
        //            return j;
        //        }
        //    }
        //    static void Main()
        //    {
        //        Test t = new Test();
        //        int ret=t.myMesh();
        //        Console.WriteLine(ret);
        //    }
        //}
        //class Test
        //{
        //    public void test(int x,int y)
        //    {
        //        int k = 0;
        //        k = x;
        //        x = y;
        //        y = k;
        //    }
        //    static void Main()
        //    {
        //        int a = 8, b = 10;
        //        Test p = new Test();
        //        Console.WriteLine("a={0},b={1}",a,b);
        //        p.test(a,b);
        //        Console.WriteLine("a={0},b={1}" , a, b);

        //    }
        //}
        //class Test
        //{
        //    public void swap(ref int x,ref int y)
        //    {
        //        int k;
        //        k = x;
        //        x = y;
        //        y = k;
        //    }
        //    static void Main()
        //    {
        //        int a = 8, b = 9;
        //        Console.WriteLine("a={0},b={1}", a, b);
        //        Test test = new Test();
        //        test.swap(ref a, ref b);
        //        Console.WriteLine("a={0},b={1}", a, b);

        //    }
        //}
        public class myTest
        {
            public string test(out string i)
            {
                i = "out 参数";
                return "out";
            }
            public static void Main()
            {
                string x;
                myTest my = new myTest();
                Console.WriteLine(my.test(out x));
                Console.WriteLine(x);
            }
        }
    }
}
