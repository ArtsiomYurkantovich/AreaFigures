using System;

namespace CalculateAreaLibrary
{
    public class Application
    {
        private bool RequestedExit;
        private Triangle _triangle { get; set; }

        public void RunApplication()
        {
            while (!RequestedExit)
            {
                DisplayInfo.ShowCommands();
                WaitForCommand();
            }
        }

        private void WaitForCommand()
        {
            int command;

            while (!int.TryParse(Console.ReadLine(), out command))
            {
                DisplayInfo.ShowErrorMsg($"Command:{command} doesn't exist\n");
            }
            ApplyCommand(command);
        }

        private void ApplyCommand(int command)
        {
            switch ((EnumCommands)command)
            {
                case EnumCommands.AreaCircle:
                    Circle circle = new Circle();
                    circle.CalculateArea(circle.EnterRadius());
                    DisplayInfo.ShowAnswernMsg(circle.ToString());
                    break;
                case EnumCommands.AreaTreangle:
                    _triangle = new Triangle();
                    double[] sides = _triangle.EnterSides();
                    double semiPerimeter = _triangle.CalculateSemiperimeter(sides);
                    _triangle.CalculateArea(sides, semiPerimeter);
                    DisplayInfo.ShowAnswernMsg(_triangle.ToString());
                    break;
                case EnumCommands.IsRightTreangle:
                    _triangle = new Triangle();
                    double[] sidesRightTreangle = _triangle.EnterSides();
                    _triangle.IsTreangleRigh(sidesRightTreangle);
                    break;
                case EnumCommands.Exit:
                    RequestedExit = true;
                    break;
                default:
                    DisplayInfo.ShowErrorMsg($"Command: {command} doesn't exist\n");
                    break;
            }
        }
    }
}
