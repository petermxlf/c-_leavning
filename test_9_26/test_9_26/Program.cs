using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//异常语句

namespace test_9_26
{
    using System;

    internal class Program
    {
        //class ExceDemo
        //{
        //    static void Main(string[] args)
        //    {
        //        //try……catch的应用,似乎与分支结构类似
        //        int[] arr1 = { 1, 0, 3, 4, 5 };
        //        int[] arr2 = { 2, 3, 0, 5, 6, 7, 8, 9 };
        //        for(int i = 0; i < arr2.Length; i++)
        //        {
        //            try
        //            {
        //                Console.WriteLine("{0}/{1}={2}", arr1[i], arr2[i], arr1[i] / arr2[i]);
        //            }
        //            catch (DivideByZeroException)//捕获异常
        //            {
        //                Console.WriteLine("除数不能为0");
        //            }
        //            catch (IndexOutOfRangeException)//捕获异常
        //            {
        //                Console.WriteLine("数组越界访问");
        //            }
        //            catch
        //            {
        //                Console.WriteLine("一些异常发生");//捕获所有异常

        //            }
        //        }
        //    }
        //}
        //class throwDome
        //{
        //    static void Main()
        //    {
        //        //使用throw主动抛出异常
        //        try
        //        {
        //            Console.WriteLine("throw抛出异常");
        //            throw new DivideByZeroException();//抛出异常
        //        }
        //        catch (DivideByZeroException e)//捕获异常
        //        {
        //            Console.WriteLine("Exception caught");
        //        }
        //        Console.WriteLine("After try/catch block");
        //    }
        //}
        class finallyDemo
        {
            static void Main()
            {
                //finally的使用,try-finally,不管是否异常都将执行finelly中的语句
                try
                {
                    Console.WriteLine("finally");
                    throw new DivideByZeroException();//抛出异常
                }
                catch
                {
                    Console.WriteLine("捕获所有异常");//捕获所有异常
                }
                finally
                {
                    Console.WriteLine("finally语句执行");//在finally中不能使用跳转语句
                }
            }
        }
    }
}
