using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1201
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            *//*int[] arr = new int[6];

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = i * i;

                Console.Write(arr[i]);

            }*/
        /*try

        {

            Console.WriteLine("Before throw. ");

            throw new DivideByZeroException();     //抛出异常

        }

        catch (DivideByZeroException e)            //捕获异常

        {

            Console.WriteLine("Exception caught. ");

        }

        Console.WriteLine("After try/catch block. ");
    }*/
        /*string Test;

        int MaxLength = 50;

        char[] str = new char[MaxLength];     //定义字符数组，用于存储栈的数据

        int i;

        int CurrentPos = 0;        //栈顶指针

        Console.Write("输入要测试的字符串：");

        Test = Console.ReadLine();       //读入字符串

        for (i = 0; i<Test.Length;i++)
 {

            if (CurrentPos >= MaxLength)      //防止栈溢出

                break;

            str[CurrentPos] = Test[i];

            CurrentPos++;

        }

        Console.Write("输入字符串的反序是：");

        for (i = 0; i < Test.Length; i++)


        {

            if (CurrentPos <= 0)

                break;

            Console.Write(str[CurrentPos - 1]);

            CurrentPos--;

        }*//*

        int[] arr1 = { 2, 5, 8, 3, 13, 32, 56, 61 };   //这里，数组arr1比arr2长

        int[] arr2 = { 1, 0, 2, 3, 0, 4 };

        for (int j = 0; j<arr1.Length;j++)

 {

            try
            {

                Console.WriteLine("{0}/{1}={2}", arr1[j], arr2[j], arr1[j] / arr2[j]);

            }

            catch                 //捕获所有异常

            {

                Console.WriteLine("一些异常发生");

            }

        }
    }*/
        /*static void Main()

        {

            try

            {

                Console.WriteLine("在try语句中抛出一个异常");

                throw new NullReferenceException();

            }

            catch

            {

                Console.WriteLine("捕获所有类型的异常");

            }

            finally

            {

                Console.WriteLine("执行finally语句块中的语句");

            }

        }*/
        /*static void Main()

        {

            int[] arr1 = { 2, 5, 8, 3, 13, 32, 56, 61 };    //这里，数组arr1比arr2长     

            int[] arr2 = { 1, 0, 2, 3, 0, 4 };

            for (int j = 0; j<arr1.Length;j++)
        
     {

                try
                {

                    Console.WriteLine("{0}/{1}={2}", arr1[j], arr2[j], arr1[j] / arr2[j]);

                }

                catch (DivideByZeroException e)       //捕获异常

                {

                    Console.WriteLine("除数不能为0");

                }

                catch (IndexOutOfRangeException e)       //捕获异常

                {

                    Console.WriteLine("数组访问越界");

                }

            }

        }*/
        /*static void Main()

        {

            int a = 0, b = 5;

            Console.WriteLine("Before exception is generated. ");

            //产生除0异常

            b = b / a;

        }*/

        /*static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t a - Add ");

            Console.WriteLine("\t s - Substract ");

            Console.WriteLine("\t m - Multiply ");

            Console.WriteLine("\t d - Divide ");

            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":

                    Console.WriteLine($" Your result: {num1} + {num2}= " + (num1 + num2));

                    break;

                case "s":

                    Console.WriteLine($" Your result: {num1} - {num2}= " + (num1 - num2));

                    break;

                case "m":

                    Console.WriteLine($" Your result: {num1} * {num2}= " + (num1 * num2));

                    break;

                case "d":

                    Console.WriteLine($" Your result: {num1} / {num2}= " + (num1 / num2));

                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }*/

        static void Main()
        {
            int j = 0;

            while (true)
            {

                while (true)
                {

                    while (true)
                    {

                        goto meno;
                    }
                }
            }

        meno:

            Console.Write(j);
        }
    }
}
