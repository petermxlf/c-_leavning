using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//第六章课后习题
namespace test_10_20
{
    //class Test
    //{
    //    static void Main()
    //    {
    //        m(3);
    //    }
    //}
    //int m()//方法声明错误
    //{
    //    Console.WriteLine("wel");
    //}
    //using System;
    //class Myclass
    //{
    //    private int x;
    //    public Myclass(int x)
    //    {
    //        x = x;
    //    }
    //    private void SetX(int a)
    //    {
    //        x = a;
    //    }
    //}
    //class Test
    //{
    //    static void Main()
    //    {
    //        Myclass m = new Myclass(18);
    //        SetX(68);//错误
    //    }
    //}
    //using System;
    //class Demo
    //{
    //    static void Func(int a,out int x,out int y)
    //    {
    //        x = a / 10;
    //        y = a % 10;
    //    }
    //    static void Main()
    //    {
    //        int k = 16;
    //        int a, b;
    //        Func(k, out a, out b);
    //        Console.WriteLine("{0},{1}", a, b);
    //    }
    //}
    //设计一个成绩类，该类能够记录学生姓名、班级、成绩和科目，并能修改成绩和输出成绩
/*    class Score
    {
        public string name;
        public string Class;
        public string score;
        public string kemu;
    }
    class Test
    {
        static void Main()
        {
            Score stu = new Score();
            stu.name = Console.ReadLine();
            stu.Class = Console.ReadLine();
            stu.kemu = Console.ReadLine();
            stu.score = Console.ReadLine();
            Console.WriteLine("name={0}班级{1}成绩{2}科目{3}",
                stu.name, stu.Class, stu.score, stu.kemu);
        }
    }*/
    
    //定义一个类，并完成对该类构造函数和析构函数的创建，体会这两个函数对类的影响
    //class Test
    //{
    //    ~Test()
    //    {
    //        Console.WriteLine("Test");//创建异常
    //    }
    //    int a, b;
    //    public Test(int a,int b)
    //    {
    //        this.a = a;
    //        this.b = b;
    //    }
    //}

    //编写一个包含5个重载的Method（）方法的例子，要求其中一个是无参方法，另外四个方法所带参数分别为值类型、引用型、
    //输出型、数组型参数，并且这些方法执行不同的打印输出功能。
    /*class Test
    {
        public void print()
        {
            Console.WriteLine("午餐");
        }
        public void print(int a)
        {
            Console.WriteLine(a);
        }
        public void print(string a)
        {
            Console.WriteLine(a);
        }
        public void print(bool a)
        {
            Console.WriteLine(a);
        }
        public void print(char[] a)
        {
            foreach(char c in a)
            {
                Console.WriteLine(a[c]);
            }
        }
    }*/

    //编写一个类，包含两个属性，其中一个是只读的，并在类实例中对他们进行调用
    /*class Test
    {
        int a;
        public int space
        {
            get
            {
                return a;
            }
            set
            {
                a= value;
            }
        }
    }
    class Tets
    {
        static void Main()
        {
            Test s = new Test();
            s.space = 1;
            Console.WriteLine(s.space);
        }
    }*/
    //事件与委托的关系是什么？如何预定或撤销时间？并举例说明
    //答：事件与委托共存关系
    //预定：事件名+=new 委托名(方法名)
    //取消：事件名-=new 委托名(方法名)
    //用程序随机产生10个数，并把这10个数按从小到大的顺序排列
    /*class Crandom
    {
        static void Main()
        {
            int[] a = new int[10];
            Random b = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = (int)b.Next(50);
            }
            foreach(int ch in a)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            for(int j = 0; j < a.Length; j++)
            {
                for (int i = j+1; i < a.Length; i++)
                {
                    if (a[j] > a[i])
                    {
                        int ret = a[i];
                        a[i] = a[j];
                        a[j] = ret;
                    }
                }
            }
            foreach(int ch in a)
            {
                Console.Write(" "+ch);
            }
        }
    }*/
    //什么是对象初始化器
}
