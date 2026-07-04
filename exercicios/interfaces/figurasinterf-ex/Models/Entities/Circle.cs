using System.Globalization;
using figurasinterf_ex.Models.Entities;
using figurasinterf_ex.Models.Enums;

namespace figurasinterf_ex.Models.Entities

{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }
        public override string ToString()
        {
            return 
            "Circle color: " 
            + Color 
            + " - Radius: " 
            + Radius 
            + " - Area: " 
            + Area().ToString("F2");
        }
    }
   
}