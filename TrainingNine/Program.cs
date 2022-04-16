using System;
using System.Globalization;
using TrainingNine.Entities;
using TrainingNine.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
           
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle os Circle: ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (answer == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
                else
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}