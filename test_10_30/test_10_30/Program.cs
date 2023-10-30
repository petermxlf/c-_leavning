using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_30
{
    using System;
    /*class Cat
    {

    }
    class Test
    {
        static void Maint()
        {
            //装箱&拆箱
            int i = 12;
            object o = i;//将数字i装入o中
            int j = (int)o;//拆箱

            //请编写一个数组，{1,2.5,"ab",cat}
            //1.装箱&拆箱
            //2.object作为基类
            Cat cat = new Cat();
            //对于1，2.4这样的值类型，都进行了装箱操作
            //1装入obj0当中，放到了obj的零号位,装箱
            //2.4装入obj1当中，放到了obj的一号位
            //“abc”时引用类型，string类型的对象，因为string的祖宗是object，继承
            //cat是引用类型，是Cat类的对象，因为Cat的父类/祖宗是object
            object[] obj = { 1, 2.4, "abc", cat };
        }
    }*/

    //泛型
    //概念：使用占位符T来代表某种类型，编译期间决定器具体类型
    //格式：classmygeneric<T>
    //使用：mygeneric<int>mg=new mygeneric<int>();

    //T是类型占位符，表示还没决定具体是什么类型，先把这个位置占了
    //占位符不一定是T，也可以用其他字符或名字

    //原理：编译器在编译的时候，会使用特化的类型替代掉类型占位符，生成绝体的class代码

    //反省可以修饰：类，方法，委托等
    class Store<T>
    {
        private T[] arr = new T[100];
        public void Put(T v,int index)
        {
            arr[index] = v;
        }
    }
    /*class Store//特化后
    {
        private int[] arr = new int[100];
        public void Put(int v,int index)
        {
            arr[index] = v;
        }
    }*/
    //因为只有一个类型占位符T，导致Arr0&Arr1必然是相同类型
    class StoreDouble<T,U>//可以使用多个类型占位符
    {
        public T[] arr0 { get; set; }
        public U[] arr1 { get; set; }
    }
    class Cat
    {
        //空类型
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store<int> store = new Store<int>();//对泛型类Store的特化，特化为int类型的类

            int m = 10, n = 20;
            //Swap<int>(ref m, ref n);
            Console.WriteLine(Add<int>( m,  n));
            Console.WriteLine(Add<double>(5.5f, 2.0f));

            //测试是否能将两个类型相加
            /*Cat c1 = new Cat();
            Cat c2 = new Cat();
            Add<Cat>(c1, c2);//不行*/

            //泛型细节：泛型可以同时提供多种数据类型的占位符（类，方法均有效）
            StoreDouble<int, float> storedouble = new StoreDouble<int, float>();

            Teacher<int, float> teacher = new Teacher<int, float>();
        }
        //泛型方法格式
        //交换两个数的值
        public static void Swap<T>(ref T a, ref T b)//使用ref修饰的参数，在方法内被修改的话，可以同时影响实参
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
        //求两个变量的和
        public static T Add<T>(T a,T b)
        {
            //return a + b;
            dynamic da = a;
            dynamic db = b;
            //dynamic将类型校验推迟到运行时
            //程序在运行时会先将数据类型进行校验，查看是否可以使用
            return da + db;
        }
    }
    class Person<T>
    {
        public T Id { get; set; }
    }
    /*class Teacher : Person<int>//将父类特化，然后继承
    {

    }*/
    /*class Teacher<B> : Person<B>//暂时不能决定父类泛型类型,暂时使用泛型类型继承
    {

    }*/
    class Teacher<T,U> : Person<T>
    {
        public U Data { get; set; }
    }
}
