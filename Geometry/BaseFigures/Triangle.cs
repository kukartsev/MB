using Interfaces.Geometry;

namespace Geometry.BaseFigures
{
    public class Triangle : I2dFigure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _halfPerimeter;

        public Triangle(double a, double b, double c)
        {
            if (double.IsNaN(a))
            {
                throw new ArgumentException("'A' side length must be a number.", nameof(a));
            }
            if (double.IsNaN(b))
            {
                throw new ArgumentException("'A' side length must be a number.", nameof(b));
            }
            if (double.IsNaN(c))
            {
                throw new ArgumentException("'A' side length must be a number.", nameof(c));
            }
            if (a <= 0)
            {
                throw new ArgumentException("'A' side length must be higher than 0.", nameof(a));
            }
            if (b <= 0)
            {
                throw new ArgumentException("'B' side length must be higher than 0.", nameof(b));
            }
            if (c <= 0)
            {
                throw new ArgumentException("'C' side length must be higher than 0.", nameof(c));
            }
            if (c >= a + b || a >= c + b || b >= a + c)
            {
                throw new ArgumentException($"Incorrect parameters, traiangle with sides {a}, {b} and {c} is not real.");
            }
            _a = a;
            _b = b;
            _c = c;
            _halfPerimeter = (a + b + c) / 2;
        }

        public double A => _a;

        public double B => _b;

        public double C => _c;

        public double Area => Math.Sqrt(_halfPerimeter * (_halfPerimeter - _a) * (_halfPerimeter - _b) * (_halfPerimeter - _c));

        public bool IsRight => (_c * _c == _a * _a + _b * _b) || (_a * _a == _c * _c + _b * _b) || (_b * _b == _c * _c + _a * _a);
    }
}
