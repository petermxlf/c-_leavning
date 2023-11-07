using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_11_7;

namespace test_11_7
{
    /*class InputArgs
    {
        public char input;
    }
    class InputManager
    {
        public event EventHandler<InputArgs> OnInput;
        public void WaitForInput()
        {
            while (true)
            {
                //1.读取用户输入的字符
                char input = Convert.ToChar(Console.Read());
                //2.调用OnInput类，将这个字符传导到监听方法
                if (OnInput != null)
                {
                    InputArgs args = new InputArgs();
                    args.input = input;
                    OnInput(this, args);
                }
                
            }
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
        InputManager im = new InputManager();
        im.OnInput += OnkeyInput;
        im.WaitForInput();
        }
        static public void OnkeyInput(object sender, InputArgs args)
        {
        Console.WriteLine("收到了事件" + args.input);
        }
    }*/

    class FoodArgs
    {
        public string food = "";
    }
    class Master
    {
        public event EventHandler<FoodArgs> OnFood;
        public void FoodAnimal(string food)
        {
            if (OnFood != null)
            {
                FoodArgs args=new FoodArgs();
                args.food = food;
                OnFood(this, args);
            }
        }
    }
    class Cat
    {
        public void Eat(object sender,FoodArgs args)
        {
            if (args.food != "鱼")
            {
                Console.WriteLine("猫猫不爱吃");
            }
            else
            {
                Console.WriteLine("猫猫爱吃");
            }
        }
    }class Pander
    {
        public void Eat(object sender,FoodArgs args)
        {
            if (args.food != "竹子")
            {
                Console.WriteLine("熊猫不爱吃");
            }
            else
            {
                Console.WriteLine("熊猫爱吃");
            }
        }
    }class Dog
    {
        public void Eat(object sender,FoodArgs args)
        {
            if (args.food != "肉")
            {
                Console.WriteLine("狗狗不爱吃");
            }
            else
            {
                Console.WriteLine("狗狗爱吃");
            }
        }
    }
    internal class Programe
    {
        static void Main()
        {
            Master master=new Master();
            Dog dog=new Dog();
            Cat cat=new Cat();
            Pander pander=new Pander();

            master.OnFood += dog.Eat;
            master.OnFood += cat.Eat;
            master.OnFood += pander.Eat;

            master.FoodAnimal("肉");
        }
    }
}
