using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_29
{
    //object类
    using System;

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //快捷键：ctrl + .
        //用途：Debug的时候打印对象信息
        public override string ToString()//重写ToString方法
        {
            string result = "";
            result += $"学号:{Id}\n";//$符号后面的大括号可以用来替换变量值
            result += $"年龄:{Age}\n";
            result += $"姓名:{Name}\n";
            return result;
        }
        public override bool Equals(object obj)
        {
            Student other = obj as Student;//强制类型转换
            if (other == null) return false;
            return Name == other.Name && Age == other.Age && Id == other.Id;
            //return true;
        }
    }
    class Cat
    {

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "lisi";
            s.Age = 18;
            //Console.WriteLine(s.ToString());

            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "lisi";
            s1.Age = 18;
            //Equals 判断两个对象是否相等
            Cat c = new Cat();

            Console.WriteLine(s1.Equals(s1));
            //不相等：虽然二者都是引用类型，但因为都是new新声明的对象，地址不同
            //ShowType(c);
        }
        static public void ShowType(object o)
        {
            //获取对象类型信息
            Type type = o.GetType();
            Console.WriteLine(type.FullName);//test_10_29.Cat
            Console.WriteLine(type.Name);//Cat
            Console.WriteLine(type.IsValueType);//传进来的对象是否是值类型
            Console.WriteLine(type.IsClass);//传来的对象是否是引用类型
        }
    }
    //System.Type GetType();
    //用于获取当前对象的类型信息(反射)
}
