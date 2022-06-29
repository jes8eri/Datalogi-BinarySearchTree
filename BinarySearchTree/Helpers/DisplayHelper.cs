namespace BinarySearchTree.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DisplayHelper
    {
        private const ConsoleColor foreground = ConsoleColor.White;
        private const ConsoleColor background = ConsoleColor.Blue;
        internal static void SetColours()
        {
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
            Console.Clear();
        }
        internal static void WriteLineColour(string text, ConsoleColor foregroundColour, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(text);
            ResetColours();
        }

        private static void ResetColours()
        {
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
        }
    }
}
