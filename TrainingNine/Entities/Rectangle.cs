using System;
using System.Collections.Generic;
using TrainingNine.Entities;
using TrainingNine.Entities.Enums;

namespace TrainingNine.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
           double area = Width * Height;
            return area;
        }
    }
}
