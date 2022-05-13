using Geometry.BaseFigures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Geometry.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void PassNanToCircleConstructor_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(double.NaN));
        }

        [TestMethod]
        public void PassInfinityToCircleConstructor_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(double.PositiveInfinity));
            Assert.ThrowsException<ArgumentException>(() => new Circle(double.NegativeInfinity));
        }

        [TestMethod]
        public void PassNegativeValueToCircleConstructor_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-7));
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, Math.PI)]
        [DataRow(10, 100 * Math.PI)]
        [DataRow(3, 3 * 3 * Math.PI)]
        public void AreaCalculation_Test(double radius, double expectedOutput)
        {
            Assert.AreEqual(expectedOutput, new Circle(radius).Area);
        }

        [TestMethod]
        public void RadiusProperty_CreateAnInstance_PropertyIsSetCorrectly()
        {
            Circle circle = new Circle(19.256);
            Assert.AreEqual(19.256, circle.Radius);
        }
    }
}