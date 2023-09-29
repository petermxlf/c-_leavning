using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_enum
{
    using System;
    internal class Program
    {
        class Enum
        {
            enum Weekday//创建一个名字为Weekday的枚举类型
            {
                Mon=1,//枚举类型默认第一个成员的值为0，后面的值依次+1
                Tue,
                Wed,
                Thu,
                Fri=7,
                Sat,
                Sun
            };
            //static void Main(string[] args)
            //{
            //    Console.WriteLine((int)Weekday.Mon);
            //    Console.WriteLine((int)Weekday.Tue);
            //    Console.WriteLine((int)Weekday.Wed);
            //    Console.WriteLine((int)Weekday.Thu);
            //    Console.WriteLine((int)Weekday.Fri);
            //    Console.WriteLine((int)Weekday.Sat);
            //    Console.WriteLine((int)Weekday.Sun);
            //    Console.WriteLine(Weekday.Mon);
            //}
            //生命一个枚举类型，通过枚举型变量，访问枚举成员，并输出枚举成员的常量值
            enum color
            {
                yellow,
                blue,
                black=purple,
                purple=5
            }
            //static color color1, color2, color3, color4;//声明枚举型常量
            //static void Main()
            //{
            //    color1 = color.yellow;
            //    color2 = color.blue;
            //    color3 = color.black;
            //    color4 = color.purple;
            //    Console.WriteLine("yellow={0}", color1);
            //    Console.WriteLine("yellow={0}", (int)color1);
            //    Console.WriteLine("blue={0}", (int)color2);
            //    Console.WriteLine("black={0}", (int)color3);
            //    Console.WriteLine("purple={0}", (int)color4);
            //}
            enum day1 {Mon=4,Tue,Wed,Thu,Fri,Sat,Sun};
            enum day2 {Mon,Tue,Wed,Thu=1,Fri,Sat,Sun};
            enum day3 {Mon,Tue=31,Wed,Thu,Fri=2,Sat,Sun};
            static void Main()
            {
                //通过枚举名访问枚举成员
                int x = (int)day1.Sat;
                int y = (int)day1.Wed;
                Console.WriteLine("Sat={0},Wed={1}", x, y);
                x = (int)day2.Sat;
                y = (int)day2.Wed;
                Console.WriteLine("Sat={0},Wed={1}", x, y);
                x = (int)day3.Sat;
                y = (int)day3.Wed;
                Console.WriteLine("Sat={0},Wed={1}", x, y);
            }
            //枚举类型使程序的可读性大大提高
        }
        
    }
}
