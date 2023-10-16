using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//委托与事件
//修饰符 delegate 返回类型 委托名(参数列表);
//委托对象
//委托名 委托对象名;
namespace test_10_16
{
    internal class Program
    {
        int indew;
        class Test
        {
            public int this[int indew]
            {
                get
                {
                    return indew;
                }
                set
                {
                    indew = value;
                }
            }
        }
        static void Main(string[] args)
        {
            int i, j, k;
            for(int a = 1; a < 10; a++)
            {
                for(int b = 0; b < 10; b++)
                {
                    for(int c = 0; c < 10; c++)
                    {
                        for(int d = 0; d < 10; d++)
                        {
                            i = a * 1000 + b * 100 + c * 10 + d;
                            j = c * 100 + d * 10 + c;
                            k = a * 100 + b * 10 + c;
                            if (i - j == k)
                                Console.WriteLine("a={0}b={1}c={2}d={3}", a, b, c, d);
                        }
                    }
                }
            }
        }
    }
}
