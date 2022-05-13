using Interfaces.Geometry;

namespace Geometry
{
    public class GeometricCalculator
    {
        public double CalculateArea(I2dFigure figure)
        { 
            return figure.Area;
        }
    }
}