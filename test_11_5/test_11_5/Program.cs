using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_11_5
{
    //需求：
    //1.player class:能偶释放aoe范围攻击技能，让波及到的敌人统一减血10滴
    //2.enemy class：能够对外提供减血的方法函数，供外界调用

    //问题：
    //委托方法需要携带的参数太多，参数还会经常变动
    //方法：将所有参数都包含到一个class里面
    class EventArgs//事件参数们
    {
        public int attack = 0;//攻击
        public bool poisoned = false;//中毒
        public bool headache = false;//眩晕变量
    }
    class Enemy
    {
        private int blood = 100;
        public void MinusBlood(object o,EventArgs args)
        {
            Console.WriteLine("Enemy被攻击");
            blood -= args.attack;

            //判断是否中毒
            if (args.poisoned)
            {
                Console.WriteLine("Enemy中毒");
            }
            if (args.headache)//判断是否眩晕
            {
                Console.WriteLine("Enemy眩晕");
            }
            //发动技能：背刺
            Player p = (Player)o;
            p.Shout();
        }
    }
    class NPC
    {
        private int blood = 100;
        public void BeAttack(object o,EventArgs args)//受击方法
        {
            Console.WriteLine("npc被攻击");
            blood -= args.attack;
        }
    }
    /*class Player//耦合于Enemy
    {
        public void DoAOE(Enemy[] enemies)
        {
            foreach(Enemy enemy in enemies)
            {
                enemy.MinusBlood(10);
            }
        }
    }*/
    //使用委托解耦合
    //在player中声明委托类型，将需要减血的方法在player类外设置给内部的委托
    class Player//偷懒是工程师进步的阶梯
    {
        //声明委托，用来规定减血的方法应该符合怎样的方法签名
        public delegate void OnAttackDelegate(object o,EventArgs args);
        public OnAttackDelegate OnAttack = null;
        public  void DoAOE()
        {
            if (OnAttack != null)
            {
                EventArgs args = new EventArgs();
                args.attack = 10;
                args.poisoned = true;
                args.headache = true;
                OnAttack(this,args);//攻击伤害
            }
        }
        public void Shout()
        {
            Console.WriteLine("玩家被反击");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Enemy e0 = new Enemy();
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            NPC npc = new NPC();

            player.OnAttack += e0.MinusBlood;
            player.OnAttack += e1.MinusBlood;
            player.OnAttack += e2.MinusBlood;
            player.OnAttack += npc.BeAttack;
            //Enemy[] es = { e0, e1, e2 };

            player.DoAOE();
        }
    }
}
