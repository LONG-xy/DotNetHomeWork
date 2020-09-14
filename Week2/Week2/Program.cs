using System;

namespace Calculate_areas
{ class Program
    {
        static void Main(string[] args)
        {
            string[] shapeType = new string[3] { "Square", "Rectangle", "Triangle" };
            double totalArea = 0;
            int legalNum = 0;
            for (int i = 0; i < 10; i++)
            {
                Shape shape;
                Random r1 = new Random();
                Random r2 = new Random();
                int t = r1.Next(0, 3); 
                shape = Factory.CreateShape(shapeType[t], r2.Next(0, 10), r2.Next(0, 10), r2.Next(0, 10));

                if (shape.IsLegal())
                {

                    Console.WriteLine("生成了一个" + shapeType[t]+ " 面积为" + shape.GetArea());
                    legalNum++;
                    totalArea += shape.GetArea();
                }
                else
                {
                    Console.WriteLine("生成失败" + shapeType[t]);
                }
            }
            Console.WriteLine("共生成了" + legalNum + "个合法的形状，总面积为" + totalArea);
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract bool IsLegal();
    }

    class Square : Shape
    {
        public double Side { get; set; }
        public override bool IsLegal() => Side > 0;
        public override double GetArea() => Side * Side;
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override bool IsLegal() => Length > 0 && Width > 0;
        public override double GetArea() => Length * Width;
    }

    class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public override bool IsLegal() => (Side1 > 0) && (Side2 > 0) && (Side3 > 0) && (Side1 + Side2 > Side3)
            && (Side2 + Side3 > Side1) && (Side1 + Side3 > Side2);
        public override double GetArea()
        {
            double p = 0.5 * (Side1 + Side2 + Side3);
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }

    public class Factory
    {
        public static Shape CreateShape(String type, params double[] side)
        {
            switch (type)
            {
                case "Square":
                    return new Square() { Side = side[0] };
                case "Rectangle":
                    return new Rectangle() { Length = side[0], Width = side[1] };
                case "Triangle":
                    return new Triangle() { Side1 = side[0], Side2 = side[1], Side3 = side[2] };
                default:
                    return null;
            }
        }
    }
}
