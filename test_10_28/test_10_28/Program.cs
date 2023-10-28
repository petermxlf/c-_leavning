using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_28
{
    using System;
    //抽象类与接口
    //接口的实现
    /*interface Imethods
    {
        void F();
        void G();
    }
    abstract class C : Imethods
    {
        public abstract void F();
        public abstract void G();
    }*/
    //对抽象方法的实现
    /*interface Imethods
    {
        void F();
        void G();
    }
    abstract class C : Imethods
    {
        void Imethods.F() { FF(); }
        void Imethods.G() { GG(); }
        protected abstract void FF();
        protected abstract void GG();
    }*/
}
