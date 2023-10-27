using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_27
{
    using System;
    //接口实现的继承机制
    //接口中方法的覆盖
    /*interface Icontrol
    {
        void Paint();
        //void Paint() { Console.WriteLine("Icontrol"); }

    }
    class Control:Icontrol
    {
        public void Paint() { Console.WriteLine("Control"); }
    }
    class Textbox : Control
    {
        new public void Paint() { Console.WriteLine("Textbox"); }
    }
    class Test
    {
        static void Main()
        {
            Control c = new Control();
            Textbox t = new Textbox();
            Icontrol ic = c;
            Icontrol it = t;
            c.Paint();
            t.Paint();
            ic.Paint();
            it.Paint();
        }
    }*/
    //调用的实际效果
    /*interface Icontrol
    {
        void Paint();
    }
    class Control : Icontrol
    {
        public virtual void Paint() { Console.WriteLine("Control"); }//虚方法的例子
    }
    class Textbox : Control
    {
        public override void Paint() { Console.WriteLine("Textbox"); }//重载的例子
    }
    class Text
    {
        static void Main()
        {
            Control c = new Control();
            Textbox t = new Textbox();
            Icontrol ic = c;
            Icontrol it = t;
            c.Paint();
            t.Paint();
            ic.Paint();
            it.Paint();
        }
    }*/
    //对重载方法的实现
    /*interface Icontrol
    {
        void Paint();
    }
    class Control : Icontrol
    {
        void Icontrol.Paint() { PaintControl(); }
        protected virtual void PaintControl() { }
    }
    class Textbox : Control
    {
        protected override void PaintControl() { }
    }*/
    //一个给出了接口重实现的例子
    /*interface Icontrol
    {
        void Paint();
    }
    class Control : Icontrol
    {
        void Icontrol.Paint() { }
    }
    class Mycontrol : Control, Icontrol
    {
        public void Paint() { }
    }*/
    //Derived类对接口方法的映射
    /*interface Imethods
    {
        void F();
        void G();
        void H();
        void I();
    }
    class Base : Imethods
    {
        void Imethods.F() { }
        void Imethods.G() { }
        public void H() { }
        public void I() { }
    }
    class Derived : Base, Imethods
    {
        public void F() { }
        void Imethods.H() { }
    }*/
    //类的重实现
    interface Ibase
    {
        void F();
    }
    interface Iderived : Ibase
    {
        void G();
    }
    class C : Iderived
    {
        void Ibase.F()
        {
            //对F进行实现的代码
        }
        void Iderived.G()
        {
            //对D进行实现的代码
        }
    }
    class D : C, Iderived
    {
        public void F()
        {
            //对F进行实现的代码
        }
        public void G()
        {
            //对G进行实现的代码
        }
    }
}
