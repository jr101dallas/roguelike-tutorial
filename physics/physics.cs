using System;

namespace physics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string GameTitle = "Utopia";

        public string GetGameDisplayName()
        {
            return $"{GameTitle}: The Tutorial";
        }
    }
}
