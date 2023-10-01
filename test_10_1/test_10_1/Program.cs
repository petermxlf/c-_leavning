using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test_10_1
{
    using System;
    using System.Diagnostics;

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
    //成员访问修饰符的作用
    class ClassA
    {
        public int a;
        public int b;
        protected int c;
        readonly double PI = 3.14;
        public void SetA()
        {
            a = 1;//正确，允许访问类自身公有成员
            b = 2;//正确。允许访问类自身私有成员
            c = 3;//正确，允许访问类自身保护成员
            //PI = 3.1415;//错误，不允许修改只读成员的值
        }
    }
    class ClassB : ClassA
    {
        public void SetB()
        {
            ClassB BaseA = new ClassB();
            BaseA.a = 11;//正确，允许访问基类公有成员
            //BaseA.b = 22;//错误，不允许访问基类私有成员
            BaseA.c = 33;//正确，允许访问基类保护成员
        }
    };
    class ClassC
    {
        public void SetB()
        {
            ClassA BaseA = new ClassA();
            BaseA.a = 111;//正确，允许访问类的其他公有成员
            //BaseA.b = 222;//错误，不允许访问类的其他私有成员
            //BaseA.c = 333;//错误，不允许访问类的其他保护成员
        }
    }
    //class Myclass
    //{
    //    public int index = 100;//非静态成员
    //    static public double fpi = 45.6;//静态成员
    //}
    //class ClassTest {
    //    static void Main()
    //    {
    //        //int a = Myclass.index;//错误，index是非静态成员，只能由对象来访问
    //        double b = Myclass.fpi;//正确，fpi是静态成员，需要由类来访问
    //        Console.WriteLine(b);
    //        //Myclass my = new Myclass();//声明对象
    //        Myclass my;
    //        my= new Myclass();//声明对象
    //        int a = my.index;//使用对象访问非静态成员

    //    }
    //}
    //用对象访问类成员
    class Pen
    {
        public string color;
        private int prive;
        public void Setprive (int newprive)
        {
            prive = newprive;
        }
        public int Getprive()
        {
            return prive;
        }
        public void Setcolor(string newcolor)
        {
            color = newcolor;
        }
        public string Getcolor()
        {
            return color;
        }
        class test
        {
            public static void Main()
            {
                Pen Mypen;
                Mypen = new Pen();
                Mypen.Setprive(5);
                Mypen.color = "black";
                Console.WriteLine("the prive is{0}", Mypen.Getprive());
                Console.WriteLine("the prive is{0}", Mypen.color);
            }
        }
    }

    
}
