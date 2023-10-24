using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10_24
{
    using System;
    using System.Reflection;

    //一个有类来实现接口的例子
    /*interface Isequence
    {
        object Add();
    }
    interface Iring
    {
        int Insert(object obj);
    }
    class Ringsequence : Isequence, Iring
    {
        public object Add() { return 0; }
        public int Insert(object obj) { return 0; }
    }*/
    //类实现多个接口的方法调用
    /*interface Icontrol
    {
        void Paint();
    }
    interface Itextbox : Icontrol
    {
        void Settext(string text);
    }
    class Textbox : Itextbox
    {
        public void Paint() { }
        public void Settext(string text) { }
    }*/
    //类继承不同接口的方法
    /*interface Icontrol
    {
        void Paint();
    }
    interface Idatabound
    {
        void Bind(Binder b);
    }
    public class Control : Icontrol
    {
        public void Paint() { }
    }
    public class Editbox : Control, Icontrol, Idatabound
    {
        public void Paint() { }
        public void Bind(Binder b) { }
    }*/

}
