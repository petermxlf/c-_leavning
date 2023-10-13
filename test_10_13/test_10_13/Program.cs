using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_13
{
    //class Test
    //{
    //    //阶乘：n*(n-1)!
    //    static int Fac(int a)
    //    {
    //        if (a == 0)
    //            return 1;
    //        else
    //            return a*Fac(a-1);
    //    }
    //    static void Main(string[] args)
    //    {
    //        //Console.WriteLine(Fac(10));
    //        //Console.WriteLine(Fib(5));
    //        int int1 = 25;
    //        int int2 = 28;
    //        var result = Add_Multiply(int1, int2);
    //        Console.WriteLine($"Add:{result.add},Multiply:{result.multiply}");
    //        (var add, var multiply) = Add_Multiply(int1, int2);
    //        Console.WriteLine($"Add:{add},Multiply:{multiply}");
    //    }
    //    public static (int add, int multiply) Add_Multiply(int int1, int int2) 
    //        => (int1 + int2, int1 * int2);//基于tuple的多返回值

    //    static int Fib(int a)//斐波那契数列
    //    {
    //        if (a == 1 || a == 2)
    //            return 1;
    //        else
    //        {
    //            return Fib(a - 1) + Fib(a - 2);
    //        }
    //    }
    //}
    class Test
    {
        /*{修饰符 } 属性的类型名 属性名
        {
        get
        {
            //可执行语句
        }
        set
        {
            //可执行语句
        }*/
        //属性的修饰符有 new/public/protected/internal/private/static/virtual/override/abstract
        private string myNo;
        public string No//在Test类中定义一个属性
        {
            get//只读属性
            {
                Console.WriteLine("1");//后执行
                return myNo;
            }
            set//只写属性
            {
                Console.WriteLine("2");//先执行
                myNo = value;//一个特殊的隐含参数value,该参数包含用户指定的值
            }
        }
        /*void set_No(string value)//No属性产生的方法
        {
            myNo = value;
        }
        string gat_No()
        {
            return myNo;
        }*/
        static void Main()
        {
            /*Test test = new Test();
            test.No = "yes";
            Console.WriteLine(test.No);
            Circle c = new Circle();
            c.R = 1.1;
            //Console.WriteLine("{0},{1}", c.PI, c.R);//c.R缺少get访问器
            Console.WriteLine("{0}", c.PI);*/

            Person p = new Person();
            p.Age = 1;
            Console.WriteLine(p.Age);
        }
    }
    class Circle
    {
        double pi = 3.14;
        double r;
        public double PI
        {
            get
            {
                return pi;
            }
        }
        public double R
        {
            set
            {
                r = value;
            }
        }
    }
    class Person//使用条件运算符进行运算，保证Person的myAge不为负数
    {
        private int myAge;
        public int Age
        {
            get
            {
                return myAge;
            }
            set
            {
                myAge = value >= 0 ? value : 0;
            }
        }
    }
}
