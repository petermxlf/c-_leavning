using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1203
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            int a = 5, b = 4, c = 6, d;
            Console.WriteLine(d = a > b ? (a > c ? a : c) : b);
        }*/
        /*static void Main(string[] args)
        {
            int i = 0, a = 0;
            while (i < 20)
            {
                for (; ; ) { if (i % 10 == 0) break; else i--; }
                i += 11;
                a += i;
            }
            Console.WriteLine("a={0}", a);
        }*/
        /*class ClassA

        {

            public int a;

            private int b;

            protected int c;

            readonly double PI = 3.14;

            public void SetA()

            {

                a = 1;            //正确，允许访问类自身公有成员

                b = 2;            //正确，允许访问类自身私有成员

                c = 3;            //正确，允许访问类自身保护成员

                PI = 3.1415926;    ①

    }

        }

        class ClassB : ClassA

        {

            public void SerB()

            {

                ClassB BaseA = new ClassB();

                BaseA.a = 11;       //正确，允许访问基类公有成员

                BaseA.b = 22;        ②

    BaseA.c = 33;        ③

}

        };

        class ClassC

        {

            public void SetB()

            {

                ClassA BaseA = new ClassA();

                BaseA.a = 111;      //正确，允许访问类的其他公有成员

                BaseA.b = 222;      ④

    BaseA.c = 333;      ⑤

}

        }*/

        /*static void Main(string[] args)
        {
            int i = 0, a = 0;
            while (i < 20)
            {
                for (; ; ) { if (i % 10 == 0) break; else i--; }
                i += 11;
                a += i;
            }
            Console.WriteLine("a={0}", a);
        }*/

        /*class Pen

        {

            public string Color;

            private int Price;

            public void SetPrice(int newPrice)

            {

                Price = newPrice;

            }

            public int GetPrice()

            {

                return Price;

            }

            public void SetColor(string newColor)

            {

                Color = newColor;

            }

            public string GetColor()

            {

                return Color;

            }

        }

        class Test

        {

            public static void Main()

            {

                Pen MyPen;

                MyPen = new Pen();

                MyPen.SetPrice(5);

                MyPen.Color = "BLACK";

                Console.WriteLine("The Price is {0}", MyPen.GetPrice());

                Console.WriteLine("The Color is {0}", MyPen.Color);

            }

        }*/

        static void Main()
        {
            //有abcd四个一位整数，符合下面算式，请写出它们的值
            //abcd-cdc=abc
            /*int A, B, C, D;
            for (A = 1; A < 10; A++)
            {
                for (B = 1; B < 10; B++)
                {
                    for (C = 1; C < 10; C++)
                    {
                        for (D = 1; D < 10; D++)
                        {
                            int a = A * 1000 + B * 100 + C * 10 + D;
                            int b = C * 100 + D * 10 + C;
                            int c = A * 100 + B * 10 + C;
                            if (a-b == c)Console.WriteLine("{0}{1}{2}{3}",A,B,C,D);
                        }
                    }
                }
            }*/

            /*int[] arr = new int[10];

            arr[0]= 1;

            arr[1]= 1;

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];

            }

            foreach (int i in arr)
            {

                Console.WriteLine(i);

            }*/
            /*int[] arr = new int[] { 5, 2, 8, 36, 12, 24, 99, 1, 105, 66 };

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length; j++)
                {

                    if (arr[i] < arr[j])
                    {

                        int ret = arr[i];

                        arr[i] = arr[j];

                        arr[j] = ret;
                    }

                }
            }

            foreach (int i in arr)
            {

                Console.WriteLine(i);

            }*/
            int x, y, z;

            for (x = 0; x <= 100; x++)
            {

                for (y = 0; y <= 100; y++)
                {

                    for (z = 0; z <= 100; z++)
                    {

                        if ((x * 5 + y * 3 + z / 3) == 100) Console.WriteLine("{0},{1},{2}", x, y, z);

                    }
                }
            }
        }
    }
}
