using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_10
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        //class Pen
        //{
        //    public string Color;
        //    private int price;
        //    public void SetPeice(int newprice)
        //    {
        //        price = newprice;
        //    }
        //    public int Getprice()
        //    {
        //        return price;
        //    }
        //    public void Setcolor(string newcolor)
        //    {
        //        Color = newcolor;
        //    }
        //    public string Getcolor()
        //    {
        //        return Color;
        //    }
        //}
        //class Test//构造函数
        //{
        //    static void Main()
        //    {
        //        Pen mypen = new Pen();
        //        Console.WriteLine("Teh price is {0}", mypen.Getprice());
        //        Console.WriteLine("The Color is {0}",mypen.Color);
        //    }
        //}
        //class Point
        //{
        //    int x, y;
        //    private Point()//在Point内部，private修饰的方法依然可以被访问
        //    {

        //    }
        //    public Point(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }
        //}
        class Point
        {
            int x, y,z;
            private Point()
            {
                this.z = 0;
            }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.z = x + y;
            }
            public Point CreatePoint()
            {
                Point p = new Point();
                p.x = 0;
                p.y = 0;
                return p;
            }
        }
            public static void Main()
            {

            }
        }
}
