using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexeevHW2
{
    class Program
    {
        static void Main()
        {
            Figure[] arr = {new Circle(), new Ellipse(), new Trigon(), new Tetragon(), new Pentagon()};

            foreach (Figure figure in arr)
            {
                if (figure is FigureWithoutCorners)
                    Console.WriteLine("Оно не умеет углов");
                if (figure is Polygon)
                    Console.WriteLine("В нём много углов");
                PrintInfo(figure);
            }

            Console.ReadKey();
        }
        static void PrintInfo(Figure figure)
        {
            Console.WriteLine($"Название фигуры {figure.Name}");
            figure.HowToDraw();
            Console.WriteLine(new String('-', 35));
        }
}
    abstract class Figure
    {
        public abstract string Name { get; }
        public abstract void HowToDraw();
    }
    abstract class FigureWithoutCorners : Figure
    {
        public override void HowToDraw()
        {
            Console.WriteLine($"Рисуем {Name} без углов");
        }
    }

    abstract class Polygon : Figure
    {
        public override void HowToDraw()
        {
            Console.WriteLine("Рисуем много углов");
        }
    }
    class Circle : FigureWithoutCorners
    {
        public override string Name { get; } = "Круг";
        public override void HowToDraw()
        {
            Console.WriteLine($"Рисуем {Name} без углов");
        }
    }
    class Ellipse : FigureWithoutCorners
    {
        public override string Name { get; } = "Овал";
        public override void HowToDraw()
        {
            Console.WriteLine($"Рисуем вытянутый {Name}");
        }
    }
    class Trigon : Polygon
    {
        public override string Name { get; } = "Треугольник";
        public override void HowToDraw()
        {
            Console.WriteLine($"Рисуем {Name}");
        }
    }
    class Tetragon : Polygon
    {
        public override string Name { get; } = "Четырёхугольник";
        public override void HowToDraw()
        {
            Console.WriteLine($"Рисуем {Name}");
        }
    }
    class Pentagon : Polygon
    {
        public override string Name { get; } = "Пятиугольник";
        public override void HowToDraw()
        {
            Console.WriteLine($"Рисуем {Name}");
        }
    }
}
