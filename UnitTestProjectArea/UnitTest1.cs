using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaLibrary; 

namespace UnitTestProjectArea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFigureTriangle()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Figure figure = new Figure(a, b, c);
            Assert.AreEqual(figure.area, 6);
        }

        [TestMethod]
        public void TestFigureTriangleIsRectangle()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Figure figure = new Figure(a, b, c);
            Assert.AreEqual(figure.isRectangle, true);
        }

        [TestMethod]
        public void TestFigureCircle()
        {
            double r = 7;
            Figure figure = new Figure(r);
            Assert.AreEqual(figure.area, 153, 9380400259);
        }
    }
}
