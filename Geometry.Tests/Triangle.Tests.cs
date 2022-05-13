using Geometry.BaseFigures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Geometry.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [DataRow(double.NaN, 1, 1)]
        [DataRow(1, double.NaN, 1)]
        [DataRow(1, 1, double.NaN)]
        [DataRow(double.NaN, double.NaN, double.NaN)]
        public void PassNanToConstructor_ThrowsArgumentException(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestMethod]
        [DataRow(-1, 1, 1)]
        [DataRow(1, -1, 1)]
        [DataRow(1, 1, -1)]
        [DataRow(-1, -1, -1)]
        public void PassNegativeValueToConstructor_ThrowsArgumentException(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }


        [TestMethod]
        [DataRow(double.PositiveInfinity, 1, 1)]
        [DataRow(1, double.PositiveInfinity, 1)]
        [DataRow(1, 1, double.PositiveInfinity)]
        [DataRow(double.NegativeInfinity, 1, 1)]
        [DataRow(1, double.NegativeInfinity, 1)]
        [DataRow(1, 1, double.NegativeInfinity)]
        [DataRow(1, double.PositiveInfinity, double.PositiveInfinity)]
        [DataRow(double.PositiveInfinity, 1, double.PositiveInfinity)]
        [DataRow(double.PositiveInfinity, double.PositiveInfinity, 1)]
        [DataRow(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)]
        [DataRow(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity)]
        public void PassInfinityValueToConstructor_ThrowsArgumentException(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestMethod]
        [DataRow(10, 1, 1)]
        [DataRow(1, 10, 1)]
        [DataRow(1, 1, 10)]
        public void TryToCreateUnrealTriangle_ThrowsArgumentException(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(3, 5, 4, 6)]
        [DataRow(4, 3, 5, 6)]
        [DataRow(4, 5, 3, 6)]
        [DataRow(5, 4, 3, 6)]
        [DataRow(5, 3, 4, 6)]
        [DataRow(6, 8, 10, 24)]

        public void AreaCalculation_Test(double a, double b, double c, double expectedOutput)
        {
            Assert.AreEqual(expectedOutput, new Triangle(a, b, c).Area);
        }

        [TestMethod]
        public void AProperty_CreateAnInstance_PropertyIsSetCorrectly()
        {
            Triangle _testTriangle = new Triangle(3, 4, 5);
            Assert.AreEqual(3, _testTriangle.A);
        }

        [TestMethod]
        public void BProperty_CreateAnInstance_PropertyIsSetCorrectly()
        {
            Triangle _testTriangle = new Triangle(3, 4, 5);
            Assert.AreEqual(4, _testTriangle.B);
        }

        [TestMethod]
        public void CProperty_CreateAnInstance_PropertyIsSetCorrectly()
        {
            Triangle _testTriangle = new Triangle(3, 4, 5);
            Assert.AreEqual(5, _testTriangle.C);
        }

        [TestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(3, 5, 4, true)]
        [DataRow(4, 3, 5, true)]
        [DataRow(4, 5, 3, true)]
        [DataRow(5, 4, 3, true)]
        [DataRow(5, 3, 4, true)]
        [DataRow(6, 8, 10, true)]
        [DataRow(3, 3, 3, false)]
        public void IsRight_Test(double a, double b, double c, bool expectedOutput)
        {
            Triangle _testTriangle = new Triangle(a, b, c);
            Assert.AreEqual(expectedOutput, _testTriangle.IsRight);
        }
    }
}