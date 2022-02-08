using LibraryFigureApp.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresUnitTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void IsRectangleSquareIsCorrect()
        {
            double[] sides = { 5, 5, 6, 6 };
            var rectangle = new Rectangle(sides);

            Assert.AreEqual(rectangle.ResultArea(), 30);
        }

        [TestMethod]
        public void IfRectangleIsSquare()
        {
            double[] sides = { 5, 5, 5, 5 };
            var rectangle = new Rectangle(sides);

            rectangle.ResultArea();

            Assert.IsTrue(rectangle.EventCheck);
        }

        [TestMethod]
        public void IfRectangleIsTrapeze()
        {
            double[] sides = { 5, 3, 5, 4 };
            var rectangle = new Rectangle(sides);

            Assert.AreEqual(rectangle.ResultArea(), 0);
        }

        [TestMethod]
        public void IfRectangleHasNotFourSides()
        {
            double[] sides = { 5, 3, 5, 4, 5 };
            var rectangle = new Rectangle(sides);

            Assert.AreEqual(rectangle.ResultArea(), 0);
        }


        [TestMethod]
        public void IsRectangleSquareIsNotCorrect()
        {
            double[] sides = { 5, 5, 6, 6 };
            var rectangle = new Rectangle(sides);

            Assert.AreEqual(rectangle.ResultArea(), 25);
        }

        [TestMethod]
        public void IfRectangleIsNotSquare()
        {
            double[] sides = { 5, 5, 5, 4 };
            var rectangle = new Rectangle(sides);

            rectangle.ResultArea();

            Assert.IsTrue(rectangle.EventCheck);
        }

        [TestMethod]
        public void IfRectangleIsNotTrapeze()
        {
            double[] sides = { 5, 3, 5, 5 };
            var rectangle = new Rectangle(sides);

            Assert.AreEqual(rectangle.ResultArea(), 0);
        }

        [TestMethod]
        public void IfRectangleHasFourSides()
        {
            double[] sides = { 5, 3, 5, 4, 5 };
            var rectangle = new Rectangle(sides);

            Assert.AreEqual(rectangle.ResultArea(), 2);
        }
    }
}
