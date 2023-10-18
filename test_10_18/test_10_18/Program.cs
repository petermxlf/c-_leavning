using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_18
{
    using System;
    //delegate void MyEventHandler();//为世间建立一个委托
    ////委托的常用格式
    ////delegate void 委托名(object sender, EventArgs e);
    //class Myevent
    //{
    //    public event MyEventHandler activate;//声明一个事件
    //    public void fire()
    //    {
    //        if (activate != null)
    //            activate();
    //    }
    //}
    //class Test
    //{
    //    static void handler()
    //    {
    //        Console.WriteLine("事件发生");
    //    }
    //    static void Main()
    //    {
    //        Myevent evt = new Myevent();
    //        //把方法handler添加到事件列表中
    //        evt.activate += new MyEventHandler(handler);
    //        evt.fire();//调用触发事件的方法
    //    }
    //}

    //c#常用的基础类
    //使用math类
    class TestMath
    {
        /*public static void Main()
        {
            Console.WriteLine("ceiling(3.1416)=" + Math.Ceiling(3.1416));
            Console.WriteLine("floor(3.1416)=" + Math.Floor(3.1416));
            Console.WriteLine("Round(518.52)=" + Math.Round(518.52));
            Console.WriteLine("Max=" + Math.Max(518.42,418));
            Console.WriteLine("sqrt(9)=" + Math.Sqrt(9));
        }*/
        //System.Random类用于产生随机数
        //Next()方法用于返回非负随机数
        //Next(int)用于返回一个不大于多指定的非负随机数
        //Next(int,int)用于返回一个介于两者之间的随机数
        //NextDouble()方法用于返回一个介于0.0和1.0之间的随机数
        //随机产生七个数，每个数在1-36之间，要求每个数不同
        /*class Rnd
        {
            static void Main()
            {
                int[] a = new int[7];
                Random ran = new Random();//生成随机数
                for(int i = 0; i < a.Length; i++)
                {
                    one_num:
                    a[i] = (int)ran.Next(36) + 1;//接受随机数
                    for(int j = 0; j < i; j++)
                    {
                        if (a[i] == a[j])//如果生成的随机数已经存在则跳转回去重新生成
                            goto one_num;//跳转
                    }
                }
                foreach(int n in a)
                {
                    Console.Write("{0}\0", n);
                }
            }
        }*/
    }
    class Teststring
    {
        static void Main()
        {
            //判断一个字符串的长度
            /*string str = "1234557890";
            int b = str.Length;
            Console.WriteLine(b);//10*/
            //比较两个字符串是否相等
            /*bool a = "hello" == "hello";
            Console.WriteLine(a);
            a = "hello" == "hell";
            Console.WriteLine(a);*/
            //Compare方法：如果两个字符串相等返回零，如果前者大于后者返回1，否则返回-1
            /*string str1 = "ab";
            int a = str1.CompareTo("abc ");//比较两个字符串大小
            Console.WriteLine(a);*/
            //字符串的链接
            //可以直接用运算符+号来连接
            /*string str1 = "One";
            string str2 = str1 + "Two" + "three";
            Console.WriteLine(str2);*/
            //Insert方法，可以在一个字符串中插入新的字符串
            //Insert(要插入的位置，字符串);
            /*string str1 = "Hi,good morning";
            string str2 = str1.Insert(3, "miss.wang,");//在第三个字符后面插入
            Console.WriteLine(str2);*/
            //字符串的替换
            //Replace方法可以把字符串中的子字符串替换成另一个字符串
            //Replace(要被替换的字符串,替换字符串);
            /*string str1 = "hello,mike,hello,taylor";
            string str2 = str1.Replace("ello", "i");//用i替换字符串ello
            Console.WriteLine(str1);
            Console.WriteLine(str2);*/
            //提取子串Substring
            //Substring(开始位置，提取数量);
            /*string orgstr = "c# makes strings easy";
            string substr = orgstr.Substring(9, 12);//从第九个字符开始往后十二个字符
            Console.WriteLine(orgstr);
            Console.WriteLine(substr);
            string str2;
            for(int j = 0; j < orgstr.Length; j+=2)
            {
                str2 = orgstr.Substring(j, 1);//循环提取
                Console.Write(str2);
            }*/
            //字符串大小写转换,ToUpper,ToLower分别转换大写或小写,
            /*string orgstr = "C# makes strings easy.";
            string str = orgstr.ToUpper();//全部转为大写
            Console.WriteLine(str);
            str = str.ToLower();//全部转为小写
            Console.WriteLine(str);*/

        }
    }
}
