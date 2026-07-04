using System.Globalization;
using figurasinterf_ex.Models.Entities;
using figurasinterf_ex.Models.Enums;

namespace figurasinterf_ex.Models.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        
        public override string ToString()
        {
            return 
            "Rectangle color: " 
            + Color 
            + " - Width: " 
            + Width 
            + " - Height: " 
            + Height 
            + " - Area: " 
            + Area().ToString("F2");
        }
    }
}