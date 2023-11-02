using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//委托中的协变和逆变
namespace test_11_2
{
    public class Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public override string ToString()
        {
            return String.Format("width:{0},height{1}", width, height);
        }
    }
    public class Rectangle : Shape { }
    public interface IIndex<out T>
    {
        T this[int index] { get; }
        int Count { get; }
    }
    public class RectangleCollection : IIndex<Rectangle>
    {
        private Rectangle[] data = new Rectangle[3]
        {
            new Rectangle{height=2,width=5},
            new Rectangle{height=3,width=8},
            new Rectangle{height=4.5,width=2.9}
        };
        public static RectangleCollection GetRectangles()
        {
            return new RectangleCollection();
        }
        public Rectangle this[int index]
        {
            get
            {
                if (index < 0 || index > data.Length)
                    throw new ArgumentOutOfRangeException("index");
                return data[index];
            }
        }
        public int Count
        {
            get { return data.Length; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IIndex<Rectangle> rectangles = RectangleCollection.GetRectangles();
            IIndex<Shape> shapes = rectangles;
            for(int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i]);
            }
        }
    }
}
