using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 事件（event关键字)
1.event修饰的委托，只能够被类内调用执行，类外不可调用执行的
2.event修饰的委托，类外不可直接赋值，只能通过+ - 增减其中蕴含的方法
 */
namespace test_11_6
{
    class Player
    {
        //定义player内部会被触发的事件委托
        public event EventHandler OnAttack = null;//使用微软内部已经定义好的委托

    public void DoAOE()
        {
            if(OnAttack != null)
            {
                OnAttack(this,EventArgs.Empty);
            }
        }
    }
    class Enemy
    {
        public void AttackMe(object sender,EventArgs e)//攻击我
        {
            Console.WriteLine("我被攻击了");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy e = new Enemy();

            player.OnAttack += e.AttackMe;
            //在类外直接调用event修饰的委托是禁止的
            //player.OnAttack(new object(), EventArgs.Empty);//可以使用，但是禁止的

            //player.DoAOE();

            /*EventHandler handler = new EventHandler(e.AttackMe);
            player.OnAttack = handler;
            handler(new object(), EventArgs.Empty);*/

            player.OnAttack += e.AttackMe;
        }
    }
}
