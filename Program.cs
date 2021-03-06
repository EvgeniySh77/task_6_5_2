using System;

namespace task_6_5_2
{
    class Triangle
    {
        //public double sideA;
        //public double sideB;
        //public double sideC;
        private double sideA;
        private double sideB;
        private double sideC;

        public double A { get{ return sideA; } set{ sideA = value; } }
        public double B { get { return sideB; } set { sideB = value; } }
        public double C { get { return sideC; } set { sideC = value; } }

        //public Triangle(double a, double b, double c)
        //{
        //    sideA = a;
        //    sideB = b;
        //    sideC = c;
        //}

        public double FindThePerimeter()
        {
            double perimeter;
            perimeter = sideA + sideB + sideC;
            return perimeter;
        }

        public double FindTheArea()
        {
            double p = FindThePerimeter() / 2; // полупериметр
            double area;
            area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return area;
        }
    }

    class Circle
    {
        //public double radius;
        private double radius;

        //public Circle(double r)
        //{
        //    radius = r;            
        //}

        public double Radius { get { return radius; } set { radius = value; } }

        public double FindTheLengthOfTheCircle()
        {
            double circleLength;
            circleLength = Math.PI * radius * 2;
            return circleLength;
        }

        public double FindTheArea()
        {            
            double area;
            area = Math.Pow(radius, 2) * Math.PI;
            return area;
        }
    }

    class Square
    {
        //public double sideOfTheSquare;
        private double sideOfTheSquare;

        //public Square(double a)
        //{
        //    sideOfTheSquare = a;
        //}

        public double Side { get { return sideOfTheSquare; } set { sideOfTheSquare = value; } }

        public double FindThePerimeter()
        {
            double perimeter;
            perimeter = sideOfTheSquare * 4;
            return perimeter;
        }

        public double FindTheArea()
        {            
            double area;
            area = Math.Pow(sideOfTheSquare, 2);
            return area;
        }
    }

    class Program
    {
        static void Main()
        {
            Triangle tr = new Triangle();
            Circle cr = new Circle();
            Square sq = new Square();

            Console.Write("Введите 1-ю сторону треугольника - ");
            //double a = double.Parse(Console.ReadLine());
            tr.A = double.Parse(Console.ReadLine());
            Console.Write("Введите 2-ю сторону треугольника - ");
            //double b = double.Parse(Console.ReadLine());
            tr.B = double.Parse(Console.ReadLine());
            Console.Write("Введите 3-ю сторону треугольника - ");
            //double c = double.Parse(Console.ReadLine());
            tr.C = double.Parse(Console.ReadLine());

            //Triangle tr = new Triangle(a, b, c);            

            Console.Write("Введите радиус круга - ");
            //double r = double.Parse(Console.ReadLine());
            cr.Radius = double.Parse(Console.ReadLine());

            //Circle cr = new Circle(r);

            Console.Write("Введите сторону квадрата - ");
            //double d = double.Parse(Console.ReadLine());
            sq.Side = double.Parse(Console.ReadLine());

            //Square sq = new Square(d);

            Console.WriteLine("Периметр треугольника {0:f1}", tr.FindThePerimeter());
            Console.WriteLine("Площадь треугольника {0:f1}", tr.FindTheArea());

            Console.WriteLine("Длина окружности {0:f1}", cr.FindTheLengthOfTheCircle());
            Console.WriteLine("Площадь круга {0:f1}", cr.FindTheArea());

            Console.WriteLine("Периметр квадрата {0:f1}", sq.FindThePerimeter());
            Console.WriteLine("Площадь квадрата {0:f1}", sq.FindTheArea());

            Console.ReadKey();
        }
    }
}
