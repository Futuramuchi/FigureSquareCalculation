using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFigure
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void IsRectanleSqareIsCorrect()
        {
            double sides[] = { 4, 4, 5, 5 };
            var rectangle = new Rectangle(sides);

        }   
    }
}
