using System;


namespace DisplayInformationLibrary
{
    public static class DisplayInfo
    {
        public static void ShowCommands()
        {
            ShowAttentionMsg(
                $"1) {EnumCommands.AreaCircle} - Calculate the area of a circle from the radius.",
                $"2) {EnumCommands.AreaTreangle} - Calculate the area of a triangle given its three sides.",
                $"3) {EnumCommands.IsRightTreangle} - Check if triangle is right triangle.",
                $"4) {EnumCommands.Exit} - Exit application.");
        }

        public static void ShowAttentionMsg(params string[] msgs)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var msg in msgs)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowAnswernMsg(params string[] msgs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var msg in msgs)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowErrorMsg(params string[] msgs)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var msg in msgs)
            {
                Console.WriteLine($"Error: {msg}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
