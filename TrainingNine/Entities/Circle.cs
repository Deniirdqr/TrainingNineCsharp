using System;
using System.Collections.Generic;
using TrainingNine.Entities;
using TrainingNine.Entities.Enums;

namespace TrainingNine.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double area = (Radius * Radius) * 3.141;
            return area;
        }
    }
}
