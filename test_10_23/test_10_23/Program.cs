using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//接口
namespace test_10_23
{
    using System;
    //接口的声明
    //接口修饰符 interface 接口名 [ : 基类接口名]{接口成员};

    //接口之间的继承关系
    /*interface IControl
    {
        void Paint();
    }
    interface ITextBox : IControl//继承了接口IControl的Paint方法
    {
        void SetText(string text);
    }
    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }
    interface IComboBox : ITextBox, IListBox//继承了接口IControl的Paint方法
                                            //、ITextBox的Set Text方法和IListBox的SetItems方法
    {
    }
    //接口成员的定义
    public delegate void StringListEvent(object sender, EventArgs e);
    public interface IMyLIst
    {
        void Add(string s);
        int Count { get; }
        event StringListEvent Changed;
        string this[int index] { get;set; }
        //它声明包含了所有可能的类型成员：一个方法、一个属性，一个事件和一个索引
        //接口成员不允许包含任何修饰符，因为接口是默认共有的
        //接口成员之间不能相互同名，若要在新的接口中定义同名覆盖，请使用new关键字
    }*/
    //接口属性
    //接口属性修饰符 接口属性类型 接口属性标识{接口属性访问器}
    //接口属性声明的访问器与类属性的访问其用法相同
    //其中访问器可以是:get; set; get;set; set;get
    //接口事件
    //接口事件修饰符 [new] event 类型名 接口事件标识符;
    //接口索引
    //接口索引修饰符 [new] 类型名 this [参数列表] {接口访问器};

    //对接口成员的访问
    /*interface ISequence
    {
        int Count { get; set; }
    }
    interface IRing
    {
        void Count(int i);
    }
    interface IRingSequence : ISequence, IRing { }
    class C
    {
        //在多继承中如果两个父级接口含有同名成员就会产生二义性
        void Test(IRingSequence rs)
        {
            //rs.Count(1);//错误，Count有二义性
            //rs.Count = 1;//错误，Count有二义性
            ((ISequence)rs).Count = 1;//正确
            ((IRing)rs).Count(1);//正确调用IRing.Count
        }
        static void Main()
        {
            C c = new C();
            //c.Test(null);
        }
    }*/
    //对接口访问的多种继承
    /*interface IInteger
    {
        void Add(int i);
    }
    interface IDouble
    {
        void Add(double i);
    }
    interface Inumber : IInteger, IDouble { }
    class C
    {
        void Test(Inumber n)
        {
            n.Add(1);//错误
            n.Add(1.0);//正确
            ((IInteger)n).Add(1);//正确
            ((IDouble)n).Add(1);//正确
        }
    }*/
    //对接口访问时方法被覆盖
    interface Ibase
    {
        void F(int i);
    }
    interface Ileft : Ibase
    {
        new void F(int i);//覆盖继承
    }
    interface Iright : Ibase
    {
        void G();
    }
    interface Iderived : Ileft, Iright { }
    class A
    {
        void Test(Iderived d)
        {
            d.F(1);//调用Ileft.F
            ((Ibase)d).F(1);//调用Ibase.F
            ((Ileft)d).F(1);//调用Ileft.F
            ((Iright)d).F(1);//调用Ibase.F
        }
    }
    //完全有效名称
    interface IControl
    {
        void Paint();
        //void IControl.Paint();//完全有效名称(需要c#8.0以上版本)
    }
    interface Itextbox : IControl
    {
        void SetTest(string test);
    }
    //接口的系统方法
    namespace System
    {
        public interface ICloneable
        {
            object Clone();
        }
    }
}
