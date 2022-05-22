using NUnit.Framework;
using System;

namespace CalculateAreaLibrary.Tests
{
    class CircleTests
    {
        [Test]
        public void CalculateArea_Radius_ReturnAreaCircle()
        {
            //arange
            double radius = 2;
            double pi = Math.Round(Math.PI, 4);
            double expected = 12.5664;

            //act
            Circle circle = new Circle();
            double actual = Math.Round(circle.CalculateArea(radius), 4);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
