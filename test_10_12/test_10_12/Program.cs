using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace test_10_12
{
    //class Test//方法重载
    //{
    //    public void print(int i)
    //    {
    //        Console.WriteLine(i);
    //    }
    //    public void print(string i)
    //    {
    //        Console.WriteLine(i);
    //    }
    //    public void print(double i)
    //    {
    //        Console.WriteLine(i);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Test test = new Test();
    //        test.print(1);
    //        test.print("理解方法重载了吗");
    //        test.print(2.3);
    //    }
    //}
    //class Test
    //{
    //    public int a;//非静态成员变量
    //    static public int b;//静态成员变量
    //    void fun1()//非静态方法
    //    {
    //        a = 10;
    //        b = 10;
    //    }
    //    static void fun2()//静态方法
    //    {
    //        //a = 10;//错误，不能访问非静态成员
    //        b = 10;
    //    }
    //}
    //class Testmy
    //{
    //    static void Main()
    //    {
    //        Test t = new Test();
    //        t.a = 10;
    //        //t.b = 10;//错误不能在实例中访问静态共有成员
    //        //Test.a = 10;//错误不能再实例中访问非静态公有成员
    //        Test.b = 10;
    //    }
    //}
    //class a//运算符的重载
    //{
    //    //一下运算符是可以重载的
    //    //一元运算符：+ - ! ~ ++ -- true false
    //    //二元运算符：+ - * / % & | ^ << >> == != > < >= <=
    //    int c = 3;
    //    public static a operator ++(a b)
    //    //public static 返回类型 operator 运算符(参数列表){}
    //    {
    //        b.c += 2;
    //        return b;
    //    }
    //    //比较运算符必须成对出现
    //    // > < true false == != >= <=
    //    static void Main()
    //    {
    //        a k = new a();
    //        k++;//从结果可以看出,每次++已经不是加1了而是将a类中的成员+2，这是运算符重载的结果
    //        Console.WriteLine(k.c);//5
    //    }
    //    //一下运算符是不允许重载的
    //    // = && ?: new typeof sizeof is
    //}
    //class Test
    //{
    //    //一元运算符重载必须使用类T的单个参数，其中+ - ！可以返回任何类型。但是++ --
    //    //的返回类型必须是类T,而且重载之后无法区分前缀和后缀，true和false要求返回类型是bool类型
    //    int c;
    //    public static int operator +(Test b)
    //    {
    //        b.c += 1;
    //        return b.c;
    //    }
    //    static void Main()
    //    {
    //        Test b = new Test();
    //        b.c++;
    //        Console.WriteLine(b.c);
    //        b.c++;
    //        Console.WriteLine(b.c);
    //    }
    //}
    //public class Test
    //{
    //    int x=0;
    //    public static bool operator true(Test t)
    //    {
    //        return t.x!=0;
    //    }
    //    public static bool operator false(Test t)
    //    {
    //        return t.x == 0;
    //    }
    //    static void Main()
    //    {
    //        Test test = new Test();
    //        test.x = 6;
    //        if (test)
    //            Console.WriteLine("Go in true");
    //        else
    //            Console.WriteLine("Go in false");
    //    }
    //}
    //二元运算符重载必须要有两个参数，其中一个必须是声明运算符的类类型，一个二元运算符可以返回任何类型
    class Test
    {
        public int a, b, c;
        public Test(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static Test operator +(Test x,Test y)
        {
            Test t = new Test(0,0,0);
            t.a = x.a + y.a;
            t.b = x.b + y.b;
            t.c = x.c + y.c;
            return t;
        }
        
    }
    class Test2
    {
        static void Main()
        {
            Test d1 = new Test(1,2,3);
            Console.WriteLine("{0},{1},{2}",d1.a, d1.b, d1.c);
            Test d2 = new Test(4, 5, 6);
            Console.WriteLine("{0},{1},{2}", d2.a, d2.b, d2.c);
            Test d3 = d1 + d2;
            Console.WriteLine("{0},{1},{2}" , d3.a, d3.b, d3.c);
        }
    }
}
