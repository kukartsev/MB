using FakeItEasy;
using Interfaces.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests
{
    [TestClass]
    public class GeometricCalculatorTests
    {
        [TestMethod]
        public void CalculateArea_PassAnyI2dFigure_ReturnsI2dFigure_AreaProperty_Value()
        {
            var figure = A.Fake<I2dFigure>();
            A.CallTo(() => figure.Area).Returns(18.1);

            Assert.AreEqual(figure.Area, new GeometricCalculator().CalculateArea(figure));
        }
    }
}