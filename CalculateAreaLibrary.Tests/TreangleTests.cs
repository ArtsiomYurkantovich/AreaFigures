using NUnit.Framework;

namespace CalculateAreaLibrary.Tests
{
    public class TreangleTests
    {
        [Test]
        public void CalculateSemiperimeter_Sides_ReturnSemiperimeter()
        {
            //arange
            double[] sides = { 6, 8, 4 };
            double expected = 9;
           
            //act
            Triangle triangle = new();
            double actual = triangle.CalculateSemiperimeter(sides);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateArea_SidesAndSemiperimeter_ReturnAreaTreangle()
        {
            //arange
            double[] sides = { 5, 4, 3 };
            double semiperimeter = 6;
            double expected = 6;
           
            //act
            Triangle triangle = new();
            double actual = triangle.CalculateArea(sides, semiperimeter);

            //assert
            Assert.AreEqual(expected, actual);
        }

       
        [Test]
        public void IsTreangleRigh_EnterSides_ReturnTreangleRigh()
        {
            //arange
            double[] sides = { 5, 4, 3 };
            bool expected = true;
            
            //act
            Triangle triangle = new Triangle();
            bool actual = triangle.IsTreangleRigh(sides);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsTreangleRigh_EnterSides_ReturnTreangleNoRigh()
        {
            //arange
            double[] sides = { 25, 20, 30 };
            bool expected = false;

            //act
            Triangle triangle = new Triangle();
            bool actual = triangle.IsTreangleRigh(sides);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}