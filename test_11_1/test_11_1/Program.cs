using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_11_1
{
    using System;
    /*internal class Program
    {
        //委托是一种引用类型变量，用于存储某个方法的引用地址
        //声明了一种数据类型（委托类型）叫做Calculate，代表的是某一类方法
        //输入：int int输出：int
        public delegate int Calculate(int x, int y);//委托
        static public int Add(int x,int y)
        {
            return x + y;
        }
        static public int Multiply(int x,int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            Calculate cal0 = new Calculate(Add);//方法Add的地址存入cal0变量中
            Calculate cal1 = new Calculate(Multiply);
            int ret = cal0.Invoke(2, 3);//使用Invoke方法传入参数
            Console.WriteLine(ret);
            int ret1=cal1(5, 5);//直接传参
            Console.WriteLine(ret1);
        }
    }*/

    //回调方法
    //CallBack Method:当某个任务执行完毕后或某事件触发后，调用的方法
    //例:
    //1.场面上所有的按钮，都是当前Button类实例化的对象
    //2.每个按钮被点击后，发生的事情都不一样
    //3.每个按钮被点击后，发生的事情由外界决定
    class Button
    {
        //1.声明一个点击消息相应的方法类型签名（委托）
        public delegate void OnClickDelegate();

        //2.声明一个OnClickDelegate类型的委托
        public OnClickDelegate Onclick = null;

        //3.在点击事件触发后，调用Onclick委托存储的方法
        public void Click()
        {
            Console.WriteLine("按钮被点击");
            if (Onclick != null) Onclick();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GameController gamecontroller = new GameController();

            Button gamestartbutton = new Button();
            gamestartbutton.Onclick = new Button.OnClickDelegate(gamecontroller.OnGameStart);

            gamestartbutton.Click();

            Button friendbutton = new Button();
            friendbutton.Onclick = new Button.OnClickDelegate(gamecontroller.Onfriend);

            friendbutton.Click();
        }
        /*public static void OnGameStart()//点击游戏开始按钮后出发的方法
        {
            Console.WriteLine("游戏开始");
        }
        static public void Onfriend()
        {
            Console.WriteLine("分享给好友");
        }*/
    }

    internal class GameController//控制游戏流程
    {
        public GameController() { }
        //游戏开始的方法
        public void OnGameStart()
        {
            Console.WriteLine("游戏开始");
        }
        //分享给好友
        public void Onfriend()
        {
            Console.WriteLine("分享给好友");
        }
    }
}
