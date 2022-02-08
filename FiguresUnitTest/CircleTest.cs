using LibraryFigureApp.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresUnitTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void IsCircleSquareCorrect()
        {
            double radius = 5d;
            CircleClass circleClass = new CircleClass(radius);

            Assert.AreEqual(Math.Round(circleClass.ResultArea(), 2), 78.54, "Данные по расчету некорректны");
        }

        [TestMethod]
        public void IsCircleSquareNorCorrect()
        {
            double radius = Convert.ToDouble('!');
            CircleClass circleClass = new CircleClass(radius);

            Assert.AreEqual(Math.Round(circleClass.ResultArea(), 2), 78.54, "Данные по расчету некорректны");
        }
    }
}
