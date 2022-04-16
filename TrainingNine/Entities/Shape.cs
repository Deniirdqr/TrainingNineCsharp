using System;
using System.Collections.Generic;
using System.Globalization;
using TrainingNine.Entities.Enums;

namespace TrainingNine.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
