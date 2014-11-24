using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 矩形面积
{
    class Program
    {
        static void Main(string[] args)
        {
            Square t = new Square(5, 6);
            double a = t.area();
            double b = t.zhouchang();
            Console.WriteLine("zhouchang ={0},mianji ={1}", b, a);
            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public abstract double area();
        public abstract double  zhouchang();
    }

    public class Square : Shape
    {
        private double _height;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private double _width;
 //       private int p1;
 //       private int p2;
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Square(double  a, double  b)
        {
            this.Height = a;
            this.Width = b;
        }

        //public Square(int p1, int p2)
        //{
        //    // TODO: Complete member initialization
        //    this.p1 = p1;
        //    this.p2 = p2;
        //}

        public override double area()
        {
            return this.Width * this.Height;
        }
        public override double  zhouchang()
        {
            return (this.Height + this.Width) / 2;
        }
    }
}
