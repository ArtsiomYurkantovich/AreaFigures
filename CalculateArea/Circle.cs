using System;

namespace CalculateAreaLibrary
{
    public class Circle
    {
        public Type TypeShape => GetType();
        public double Radius { get; set; }
        public double Area { get; set; }
        public double CalculateArea(double radius)
        {
            Area = Math.PI * Math.Pow(radius, 2);
            return Area;
        }

        public double EnterRadius()
        {
            double radius;
            DisplayInfo.ShowAttentionMsg("Enter please radius size: ");
            while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                DisplayInfo.ShowErrorMsg("Enter please correct radius size: ");
            }

            Radius = radius;
            return Radius;
        }

        public override string ToString() => $"Figure: {TypeShape.Name}, Radius: {Radius}, Area = {Math.Round(Area, 3)} ";
    }
}