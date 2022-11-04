using Codigo_087.Model.Enums;

namespace Codigo_087.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
