using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

/*修饰符 类型名 this[参数列表]
{
    只读属性
    只写属性
}*/
/*在set方法中，可以使用一个特殊的隐含参数value，用以表示用户指定的值，而get方法使用return返回的值，
    这与属性类似，但这里没有属性名，而是用this表示索引，使用参数列表来表示索引的参数，这与方法相似，
    但与方法不同的是，索引至少需要一个参数，用方括号，而不是用圆括号，同时没有方法名，而是用this*/
namespace test_10_15
{
    internal class Program
    {
        class Test
        {
            private string[] str = new string[4];
            public string this[int a]//索引值器
            {
                //属性可以是静态成员
                //但索引只能是实例成员
                get
                {
                    if (a >= 0 && a <= 4)
                        return str[a];
                    else
                        return null;
                }
                set
                {
                    if (a >= 0 && a <= 4)
                        str[a] = value;
                }
            }

        }
        class Index//使用非整形下标
        {
            //索引指示器可以被重载
            string[] name = new string[4] { "a", "b", "c", "d" };
            int i = 0;
            public int this[string index]
            {
                get
                {
                    for (i = 0; i < name.Length; i++)
                    {
                        if (index == name[i])
                            break;
                        
                    }
                    if (i == name.Length)
                        return -1;
                    else
                        return i + 1;
                }
            }
    }
        static void Main(string[] args)
            //索引器的优点就是用户可以定义整形和非整形两种下标
        {
            Test test = new Test();
            test[0] = "hello";
            test[1] = "world";
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine(test[i++]);
            }
            Index ind = new Index();
            if (ind["a"] != -1)
                Console.WriteLine(ind["a"]);
            else
                Console.WriteLine("序列列中没有该字符");
        }
    }
}
