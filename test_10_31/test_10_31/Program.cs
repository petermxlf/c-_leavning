using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//泛型约束
//对泛型中传入的类型进行校验，规定必须满足的条件
//泛型约束分类
/*
1.引用类型约束：必须是引用类型
2.值类型约束：泛型必须是值类型
3.new约束：泛型必须包含无参构造方法
4.多个约束条件
5.类名约束：泛型必须是某类或派生类
6.接口约束：泛型必须实现一个或多个接口
7.多泛型约束：多个where约束条件
 */
//泛型约束&继承
//拥有泛型约束的类作为父类，对其子类可以选择特化父类，或者使用与父类同样的约束条件/更严格的约束
namespace test_10_31
{
    //1.引用类型约束
    class Classname<T> where T : class
    {

    }
    //2.值类型约束
    class Classstruct<T> where T : struct
    {

    }
    //3.new约束
    class Classnew<T> where T : new()
    {

    }
    class Cat
    {
        void Point() { }//无参构造方法
    }
    //4.多个约束条件
    class Classadd<T> where T : class, new()//如果包含new关键词，把new放在最后
    {

    }
    class Dog
    {
        void Point2() { }//无参
    }
    //5.类名约束
    class ClassName<T> where T : Teacher
    {

    }
    class Teacher
    {

    }
    //6.接口约束
    class Classinterface<T> where T : B,C
    {

    }
    interface B { }
    interface C { }
    class A : B, C
    {

    }
    //7.多泛型约束
    class Morewhere<T,B> where T:Ione where B : struct
    {

    }
    class Ione
    {

    }

    //泛型约束&继承
    class Parent
    {

    }
    class Child:Parent
    {

    }
    class X<T> where T : Parent { }
    class Mytest : X<Parent>//特化父类
    {

    }
    class MyTest2 : X<Child>//特化父类
    {

    }
    //与父类相同约束
    class Mytest<B>:X<B>where B : Parent
    {

    }
    //更严格的约束
    class Mytest2<B>:X<B>where B : Child
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Classname<string> str = new Classname<string>();//泛型必须是引用类型
            Classstruct<int> s2 = new Classstruct<int>();//泛型必须是值类型
            Classnew<Cat> c3 = new Classnew<Cat>();//泛型必须是无参构造方法
            Classadd<Dog> c4 = new Classadd<Dog>();//表示泛型必须是引用类型，而且包含无参方法
            ClassName<Teacher> c5 = new ClassName<Teacher>();//泛型为指定类名
            Classinterface<A> c6 = new Classinterface<A>();//泛型必须继承一个或多个接口
            Morewhere<Ione, int> c7 = new Morewhere<Ione, int>();//多个泛型约束，表示为指定类名和值类型
        }
    }
}
