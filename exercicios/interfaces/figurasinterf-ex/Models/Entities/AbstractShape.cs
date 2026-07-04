using figurasinterf_ex.Models.Enums;

namespace figurasinterf_ex.Models.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}