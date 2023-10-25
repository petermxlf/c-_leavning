using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_25
{
    using System;
    //类实现显示接口成员执行体继承
    interface Icoloneable
    {
        object clone();
    }
    interface Icomparable
    {
        int Compatable(object other);
    }
    class Listentry : Icoloneable, Icomparable
    {
        object Icoloneable.clone() { return 0; }
        int Icomparable.Compatable(object other) { return 0; }
    }
    //对类与接口调用实现
    interface Ifoo
    {
        void Execute();
    }
    interface Ibar
    {
        void Execute();
    }
    /*class Tester : Ifoo, Ibar//继承接口
    {
        void Ifoo.Execute()
        {
            Console.WriteLine("Ifoo.Execute");
        }
        void Ibar.Execute()
        {
            Console.WriteLine("Ibar.Execute");
        }
    }*/
    class Tester : Ifoo, Ibar//继承接口
    {
        void Ifoo.Execute()
        {
            Console.WriteLine("Ifoo.Execute");
        }
        void Ibar.Execute()
        {
            Console.WriteLine("Ibar.Execute");
        }
        public void Execute()//修改后可以被调用
        {
            ((Ifoo)this).Execute();
        }
    }
    class Test
    {
        //对类与接口调用实现
        /*static void Main()
        {
            Tester tester = new Tester();
            Ifoo ifoo = (Ifoo)tester;
            ifoo.Execute();
            Ibar ibar = (Ibar)tester;
            ibar.Execute();
        }*/

        //对接口中Ifoo和Ibar不明确的调用关系
        public static void Main()
        {
            Tester tester = new Tester();
            tester.Execute();//不明确调用
            //无法被调用，因为显示接口成员执行体只能通过接口的实例引用接口的成员名称来访问
        }
    }
}
