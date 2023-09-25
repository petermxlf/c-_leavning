using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcome1
{
        using System;//使用using语句导入system命名空间中
    internal class Program
    {
    class welcome1//类
    {
        static void Main(string[] args)
        {
                //System.Console.WriteLine("欢迎使用c#\n");
                //Console.WriteLine("欢迎使用c#\n");//因为前面使用using导入命名空间，所以可以不用System
                //double k = 1234.789;
                //Console.WriteLine("{0,8:c}",k);//货币形式输出
                //Console.Write("{0,8:c}",k);//货币形式输出
                //Console.WriteLine("{0,10:c3}",k);
                //Console.Write("{0,10:c3}\n",k);
                string str;
                Console.WriteLine("请输入你的名字>");
                str= Console.ReadLine();
                Console.WriteLine("{0},欢迎你", str);
        }
    }
        
    }
}
