using System;

namespace Simple_Factory
{
   using System;

namespace project2
{
    public interface Shape
    {
        double Calculate();
      
    }

    public class Rectancle : Shape
    {
        public double Calculate()
        {
            Random random = new Random();
            double width = random.Next(0,10);
            double height = random.Next(0,10);
            Console.WriteLine($"矩形的长是{width} 宽是{height}");
            return width*height;
        }
    }

    public class Square : Shape 
    {
        public double Calculate()        
        { 
        Random random= new Random();
        double length = random.Next(0, 10);
        Console.WriteLine($"正方形的边长是{length}");
            return length*length;
        }
    }

    public class Triangle:Shape
    {
       
        public double Calculate()
        {
            Random random = new Random();
            double a = random.Next(0, 10);
            double b = random.Next(0, 10);
            double c = random.Next(0, 10);

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"三角形的边长是{a},{b},{c}");
            return  s;
        }
    }
    

    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null)
                return null;
               else if (shapeType.Equals("Rectangle"))
               {
                    return new Rectancle();
               }
               else if(shapeType.Equals("Square"))
               {
                    return new Square();
               }

               else if(shapeType.Equals("Triangle"))
               {
                    return new Triangle();
               }
               else
                return null;
        }
    }

    public class FactoryPattern 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--欢迎来到随机图形工厂--");
            Console.WriteLine("随机生产十个图形并计算面积");
            Random type = new Random();

            for (int i = 1; i < 11; i++)
            {
                int t = type.Next(0, 3);
                ShapeFactory shapeFactory = new ShapeFactory();
                if (t == 0)
                {
                    Shape shape1 = shapeFactory.getShape("Rectangle");
                    double answer1 = shape1.Calculate();
                    Console.WriteLine($"第{i}次产生的矩形的面积是" + answer1);
                }
                else if (t == 1)
                {
                    Shape shape2 = shapeFactory.getShape("Square");
                    double answer2 = shape2.Calculate();
                    Console.WriteLine($"第{i}次产生的正方形的面积是" + answer2);
                }
                else if (t == 2)
                {
                    Shape shape3 = shapeFactory.getShape("Triangle");
                    double answer3 = shape3.Calculate();
                    Console.WriteLine($"第{i}次产生的三角形的面积是" + answer3);
                }

            }

        }
    }

}
}
