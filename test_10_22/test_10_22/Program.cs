using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//当方法中包含virtual修饰符时，方法就被称为虚方法，反之被称为非虚方法
//虚方法定义中不能包含static/abstract或override修饰符

//继承
//父类也称基类，子类也称派生类
namespace test_10_22
{
    using System;
    /*internal class Program
    {
        class Pet
        {
            public string name = "";
            public int age = 0;
        }
        class Cat:Pet//子类Cat继承Pet父类的公有成员
        {
            public void speed()
            {
                Console.WriteLine("喵~");
            }
        }
        public  class ParentClass
        {
            public ParentClass()//构造函数在方法被调用是自动执行
            {
                Console.WriteLine("Patent Constructor");
            }
            public void print()
            {
                Console.WriteLine("I'm a Parent Class.");
            }
        }
        public class ChildClass : ParentClass//继承父类
        {
            public ChildClass()//构造函数
            {
                Console.WriteLine("Child Constructor");
            }
        }
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //cat.name = "miaomiao";
            //cat.age = 1;
            //Console.WriteLine("name={0},age={1}", cat.name, cat.age);

            ChildClass child = new ChildClass();
            child.print();
        }
    }*/

    //base关键字
    //派生类同基类进行通信
    /*在使用base时，要注意base指的是调用“对象”本身，不仅是指基类中看到的变量或方法
     注意事项：
     通过base不仅可以访问直接基类中定义的域和方法，还可以访问间接基类中定义的域和方法
    在构造方法中调用基类的构造方法时，base（）指直接基类的构造方法，而不能指间接基类的构造方法，这是因为构造方法是不能继承的
    由于base指的是对象，所以她不能再static环境中使用，包括静态域、静态方法和static构造方法*/
    /*public class Parent
    {
        string parentString;
        public Parent()
        {
            Console.WriteLine("Parent Constructor");
        }
        public Parent(string myString)
        {
            parentString = myString;
            Console.WriteLine(parentString);
        }
        public void print()
        {
            Console.WriteLine("I'm a parent Class");
        }
    }
    public class Child : Parent
    {
        public Child():base("Form Derived")//与父类建立通信,括号中内容是他的实参
        {
            Console.WriteLine("Child Constructor.");
        }
        public void print()//覆盖了父类中的print方法,除非指明父类print方法否则不会调用父类print成员
        {
            base.print();//使用base关键字访问父类成员
            Console.WriteLine("I'm a Child Class.");
        }
        public static void Main()
        {
            Child child = new Child();
            child.print();
            ((Parent)child).print();//指明调用父类成员
        }
    }*/

    //覆盖
    //override限定符可以用于子类覆盖父类中的方法
    //覆盖方法声明不能包括new,static,virtual,abstract中的任何一个
    public class A
    {
        int x;
        public virtual void PrintFields()
        {
            Console.WriteLine(x);
        }
    }
    public class B : A
    {
        int y;
        public override void PrintFields()//覆盖
        {
            base.PrintFields();//调用父类方法
            Console.WriteLine(y);
        }
    }
    class Test
    {
        public static void Main()
        {
            
        }
    }
    /*//派生类隐藏基类的方法
    public class A1
    {
        public virtual void F() { }
    }
    public class B1 : A1
    {
        public virtual void F() { }//警告，隐藏被继承了的F()
    }*/

    //派生类中不同限定符的区别
    public class A1
    {
        public virtual void F() { }//虚拟方法
    }
    public class B1 : A1
    {
        new private void F() { }//在B中隐藏A.F方法
    }
    public class C1 : B1
    {
        public override void F(){}//正确，覆盖A.F方法
    }
}
