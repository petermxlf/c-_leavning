using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_19
{
    /*class Test
    {
        static void Main()
        {
            *//*string Username, password;
            bool Allow = false;
            for(int i = 0; i < 3; i++)
            {
                Console.Write("请输入用户名");
                Username = Console.ReadLine();
                Console.Write("请输入口令");
                password = Console.ReadLine();
                if (Username.Trim().ToLower() == "admin" || password == "123456")//去掉用户信息前后的空格后判断
                {
                    Allow = true;
                    break;
                }
                else if (i < 2)
                    Console.WriteLine("你输入的用户名或口令不正确，请重新输入");
            }
            if (Allow == false)
                Console.WriteLine("非法用户，无法进入");
            else
                Console.WriteLine("欢迎进入");*//*
            //访问字符串中的字符
            //string orgste = "c# makes strings easy.y ";
            *//*char a = orgste[1];
            char b = orgste[orgste.Length - 2];
            Console.WriteLine("{0} {1}",a, b);*//*

            //搜索字符串
            //int a = orgste.IndexOf("ke");
            //int b = orgste.LastIndexOf("s");
            //Console.WriteLine("{0},{1}", a, b);
        }
    }*/

        //命名空间的声明
        //namespace 命名空间名{
        //命名空间定义体}
        namespace N1
    {
        //namespace N1.N2
        //{
        //    class A { }
        //    class B { }
        //}
        namespace N1.N2
        {
            class A { }
        }
        namespace N1.N2
        {
            class B { }
        }
    }
    //在一个命名空间中可以包含多个成员声明，这些声明共同组成了这个命名空间的成员。命名空间成员的类型多种多样，
        //可以是一个类、结构、枚举、接口、委托等，也可以是另一个命名空间，无论是哪一种，命名空间成员类型声明
        //都分别和各自类型声明要求一致。
        //命名空间的使用
        //为命名空间指定别名
        namespace MyCompany.FirstNameapace//声明命名空间
    {
        class ClassA { }//声明类
    }
    namespace Secondnamespace
    {
        //使用using语句为第一个命名空间指定别名
        using N1 = MyCompany.FirstNameapace;
        //使用using语句为第一个命名空间中的类型Class A指定别名
        using CA = MyCompany.FirstNameapace.ClassA;
        //然后就可以使用别名来访问相应的命名空间和类型
        class ClassB : N1.ClassA
        {
            //使用using语句可以把一个命名空间中的类型导入到包含该using语句的命名空间中。
            //这样，就可以直接使用命名空间中的类型的名字。
        }
        class ClassC : CA
        {

        }
    }
    //命名空间使用指令
    //using 命名空间名;
    namespace N1.N2//导入命名空间
    {
        class ClassA
        {

        }

    }
    namespace N3//这种方法using必须放在所有声明之前
    {
        using N1.N2;
        class ClassB : ClassA
        {

        }
    }

}
