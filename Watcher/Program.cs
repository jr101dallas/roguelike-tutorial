using System;
using Physics;

namespace Watcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameName = GetGameDisplayName();
            var displayText = $"Hello World! Welcome to {gameName}";
            Console.WriteLine(displayText);

            var unv = new Universe();
        }

        public const string GameTitle = "Utopia";

        public static string GetGameDisplayName()
        {
            return $"{GameTitle}: The Tutorial";
        }
    }
}
