using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 委托的多播
含义：存在一个主委托，内涵多个子委托，运行主委托的时候，会将蕴含的子委托依次执行
 */
namespace test_11_3
{
    internal class Program
    {
        public delegate int CalculateDelegate(int x, int y);
        public static int Add(int x,int y)
        {
            Console.WriteLine("Add"+(x + y));
            return x + y;
        }
        public static int Multiply(int x,int y)
        {
            Console.WriteLine("Multiply"+(x * y));
            return x * y;
        }
        static void Main(string[] args)
        {
            CalculateDelegate cal0 = new CalculateDelegate(Add);
            CalculateDelegate cal1 = new CalculateDelegate(Multiply);
            CalculateDelegate cal2 = new CalculateDelegate(Add);

            //1.通过表达式创建多播委托
            CalculateDelegate cal = cal0 + cal1 + cal2;

            //1.1获取总委托里面的子委托构成的数组
            Delegate[] delegates=cal.GetInvocationList();

            //1.2循环遍历每个子委托并且执行，打印返回值
            /*for(int i = 0; i < delegates.Length; i++)
            {
                CalculateDelegate c = (CalculateDelegate)delegates[i];//强制类型转换
                int result = c(1, 3);
                Console.WriteLine(result);
            }*/

            foreach(CalculateDelegate c in cal.GetInvocationList())
            {
                int result = c(1, 3);
                Console.WriteLine(result);
            }

            //1.通过表达式创建多播委托
            //CalculateDelegate cal = cal0 + cal1;
            //cal -= cal0;

            //2.通过初始化为null，然后经过加法运算创建多播委托
            /*CalculateDelegate cal = null;
            cal += cal0;//cal的创建在这句代码，创建全新的委托对象
            cal += cal1;*/

            //3.通过等于某个子委托来创建多播委托
            /*CalculateDelegate cal = cal0;//并不是将cal0的地址给到cal，而是创建新的cal对象
            cal += cal1;*/

            /*int result = cal(1, 3);
            Console.WriteLine(result);*/

            //特殊案例
            /*CalculateDelegate mcal0 = cal0 + cal1;//Add+Multiply
            CalculateDelegate mcal1 = cal0 + cal2;//Add+Add
            CalculateDelegate mcal = mcal0+mcal1;
            mcal(1, 3);*/
        }
    }
}
