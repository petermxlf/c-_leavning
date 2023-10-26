using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_26
{
    using System;
    //调用基类方法实现接口成员
    /*interface Inter
    {
        void F();
    }
    class Class
    {
        public void F() { }
        public void C() { }
    }
    class Class2 : Class, Inter
    {
        new public void C() { }
    }*/
    //在一个类中，显示说明的接口成员比其他成员优先实现的实例
    /*interface Iclone
    {
        object Clone();
    }
    class C : Iclone
    {
        object Iclone.Clone() { return 0; }
        public object Clone() { return 0; }
    }*/
    //实例中的方法
    /*interface Icontrol
    {
        void Paint();
    }
    interface Ifrom
    {
        void Paint();
    }
    class Page : Icontrol, Ifrom
    {
        public void Paint() { }
    }*/
    //接口成员
    /*interface Icontrol
    {
        void Paint();
    }
    interface Ifrom
    {
        void Paint();
    }
    class Page : Icontrol, Ifrom
    {
        void Icontrol.Paint() {//具体实现接口的代码
                               }
        void Ifrom.Paint()
        {
            //具体的接口实现代码
        }
    }*/
    //对下面实例的解释
    /*interface Ibase
    {
        int P() ;
    }
    interface Iderived : Ibase
    {
        new int P();
    }

    //完成两个接口成员都采用显示接口成员执行体来实现
    class C : Iderived
    {
        int Ibase.P()
        {
            //get{具体的接口实现代码}
        }
        int Iderived.P()
        {
            //具体的接口实现代码
        }
    }
    //对Ibase的接口成员采用显示接口成员执行体来实现
    class C : Iderived
    {
        int Ibase.P()
        {
            //get(具体的接口实现代码}
        }
        public int P()
        {
            //具体的接口实现代码
        }
    }
    //对Iderived的接口成员采用显示接口成员执行体来实现
    class C : Iderived
    {
        public int P()
        {
            //get{//具体的接口实现代码}
        }
        int Iderived.P()
        {
            //具体的接口实现代码
        }
    }*/
    //接口的继承
    /*interface Icontrol
    {
        void Paint();
    }
    interface Itextbox : Icontrol
    {
        void Settext(string text);
    }
    interface Ilisebox : Icontrol
    {
        void Setitems(string[] items);
    }
    class Conbobox : Icontrol, Itextbox, Ilisebox
    {
        void Icontrol.Paint() { }
        void Itextbox.Settext(string text) { }
        void Ilisebox.Setitems(string[] items) { }
    }*/
}
