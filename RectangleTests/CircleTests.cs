using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleTest()
        {
            Triangle t = new Triangle(5, 4, 3);
            Circle c = new Circle(10);
            Figure f = new Triangle(30, 50, 40);

            Assert.AreEqual(6, t.CalcSquare());
            Assert.IsTrue(t.IsRight());
            Assert.AreEqual(Math.PI * 100, c.CalcSquare());
            Assert.AreEqual(600, f.CalcSquare());
            
        }
    }
}