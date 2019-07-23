using System;
using CalcuateShapArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForCalculateArea
{
    [TestClass]
    public class UnitTest1
    {
        IShape objectForAll;
        double result;
        
        [TestMethod]
        public void TestForCircle()
        {
            objectForAll = new Circle(5);
            result = objectForAll.CalculateAreaOfShape();
            Assert.AreEqual(78.5, result,1);
        }

        [TestMethod]
        public void TestForRectangle()
        {
            objectForAll = new Rectangle(5,5,5);
            result = objectForAll.CalculateAreaOfShape();
            Assert.AreEqual(125, result, 1);
        }

        [TestMethod]
        public void TestForSquare()
        {
            objectForAll = new Square(5);
            result = objectForAll.CalculateAreaOfShape();
            Assert.AreEqual(25, result, 1);
        }

        [TestMethod]
        public void TestForTriangle()
        {
            objectForAll = new Triangle(5,2);
            result = objectForAll.CalculateAreaOfShape();
            Assert.AreEqual(5, result,1);
        }
    }
}
