using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_9_29
{
    using System;
    internal class Program
    {
        class Stackspace
        {
            static void Main(string[] args)
            {
                //一维数组模拟栈操作
                string test;
                int Maxlength = 50;
                char[] str = new char[Maxlength];//创建字符数组
                Console.Write("请输入需测试的字符串:");
                test = Console.ReadLine();
                int Currentpoa = 0;//栈顶指针
                int i = 0;
                for (i = 0; i < test.Length; i++)
                {
                    if (Currentpoa >= Maxlength)
                        break;
                    str[Currentpoa] = test[i];
                    Currentpoa++;
                }
                Console.Write("输入字符串的反序是:");
                for (i = 0; i < test.Length; i++)
                {
                    if (Currentpoa <= 0)
                        break;
                    Console.Write(str[Currentpoa - 1]);
                    Currentpoa--;
                }
            }
        }
        
    }
}
