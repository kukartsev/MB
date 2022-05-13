using Interfaces.Geometry;

namespace Geometry.BaseFigures
{
    public class Circle: I2dFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (double.IsNaN(radius) || double.IsInfinity(radius))
            {
                throw new ArgumentException("Radius must be a number.", nameof(radius));
            }
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be a positive value.", nameof(radius));
            }
            _radius = radius;
        }

        public double Radius => _radius;

        public double Area => Math.PI * _radius * _radius;
    }
}
