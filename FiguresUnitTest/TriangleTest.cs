using LibraryFigureApp.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresUnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void IsTriangleSquareIsCorrect()
        {
            double[] sides = { 5, 6, 7 };

            var triangle = new TriangleClass(sides);

            Assert.AreEqual(triangle.ResultArea(), 14,6969384566991);
        }

        [TestMethod]
        public void IsTriangleIsStraight()
        {
            double[] sides = { 5, 12, 13 };

            var triangle = new TriangleClass(sides);
            triangle.ResultArea();

            Assert.IsTrue(triangle.EventCheck);
        }

        [TestMethod]
        public void IfTriangleIsNotRectangle()
        {
            double[] sides = { 5, 12, 13 };

            var triangle = new TriangleClass(sides);

            Assert.AreNotEqual(triangle.ResultArea(), 0);
        }

        [TestMethod]
        public void IsTriangleHalfPerimeterCorrect()
        {
            double[] sides = { 4, 8, 6 };

            var triangle = new TriangleClass(sides);
            triangle.ResultArea();

            Assert.AreEqual(triangle.HalfPerimeter, 9);
        }



        [TestMethod]
        public void IsTriangleAllowFourSides()
        {
            double[] sides = { 5, 12, 13, 8 };

            var triangle = new TriangleClass(sides);

            Assert.AreNotEqual(triangle.ResultArea(), 0);
        }

        [TestMethod]
        public void IsTriangleSquareIncorrect()
        {
            double[] sides = { 5, 12, 13 };

            var triangle = new TriangleClass(sides);

            Assert.AreEqual(triangle.ResultArea(), 156);
        }

        [TestMethod]
        public void IsTriangleNotStraight()
        {
            double[] sides = { 5, 12, 35 };

            var triangle = new TriangleClass(sides);
            triangle.ResultArea();

            Assert.IsTrue(triangle.EventCheck);
        }

        [TestMethod]
        public void IsTriangleHalfPerimeterNotCorrect()
        {
            double[] sides = { 4, 8, 6 };

            var triangle = new TriangleClass(sides);
            triangle.ResultArea();

            Assert.AreNotEqual(triangle.HalfPerimeter, 9);
        }
    }
}
