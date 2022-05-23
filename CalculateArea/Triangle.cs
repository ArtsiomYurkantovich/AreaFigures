using DisplayInformationLibrary;
using System;

namespace CalculateAreaLibrary
{
    public class Triangle
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public double Area { get; set; }
        public Type TypeShape => GetType();
        public override string ToString() => $"Figure: {TypeShape.Name}, A = {FirstSide}, B = {SecondSide}, C = {ThirdSide}: Area = {Math.Round(Area, 3)} ";

        public double CalculateArea(double[] sides, double semiperimeter)
        {
            Area = Math.Sqrt(semiperimeter * (semiperimeter - sides[0]) * (semiperimeter - sides[1]) * (semiperimeter - sides[2]));
            return Area;
        }

        private double EnterSideofTriangle()
        {
            double side;
            DisplayInfo.ShowAttentionMsg("Enter please side size: ");
            while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
            {
                DisplayInfo.ShowErrorMsg("Enter please correct side size: ");
            }
            return side;
        }

        public double[] EnterSides()
        {
            FirstSide = EnterSideofTriangle();
            SecondSide = EnterSideofTriangle();
            ThirdSide = EnterSideofTriangle();

            while (FirstSide + SecondSide < ThirdSide || SecondSide + ThirdSide < FirstSide || FirstSide + ThirdSide < SecondSide)
            {
                DisplayInfo.ShowErrorMsg("The triangle with such sides does not exist.");
                DisplayInfo.ShowErrorMsg("The sum of two sides of a triangle must always be greater than the third side");
                EnterSides();
            }

            double[] sides = new double[] { FirstSide, SecondSide, ThirdSide };

            return sides;
        }

        public double CalculateSemiperimeter(double[] sides)
        {
            var semiperimeter = (sides[0] + sides[1] + sides[2]) / 2;
            return semiperimeter;
        }

        public bool IsTreangleRigh(double[] sides)
        {
            bool isTraenglRight = false;

            if (sides[0] == Math.Sqrt(Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)) ||
               sides[1] == Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[2], 2)) ||
               sides[2] == Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))
            {
                DisplayInfo.ShowAnswernMsg("The triangle is right angled");
                isTraenglRight = true;
            }
            else
            {
                DisplayInfo.ShowAnswernMsg("The triangle is not right angled");
                isTraenglRight = false;
            }

            return isTraenglRight;
        }
    }
}
