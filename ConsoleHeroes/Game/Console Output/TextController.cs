namespace ConsoleHeroes.Game.Output
{
    /// <summary>
    /// Static class responsible for printing and formatting all text given by the Narrator class
    /// </summary>
    internal static class TextController
    {
        static int textCenter = 36;
        static int windowSize = 72;
        static string fancyLeftMargin = "|>";
        static string fancyRightMargin = "<|";

        public static void writeText(int speed, ConsoleColor foregroundColor, ConsoleColor backgroundColor, string str)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            int halfStringLength = str.Length / 2;
            int totalCharsPrinted = fancyLeftMargin.Length;

            Console.Write(fancyLeftMargin);
            for (int i = 0; i < textCenter - halfStringLength; i++) { Console.Write(" "); totalCharsPrinted++; }

            foreach (char c in str)
            {
                Thread.Sleep(speed);
                totalCharsPrinted++;
                Console.Write(c);
            }

            for (int i = 0; i < windowSize - totalCharsPrinted; i++) { Console.Write(" "); }
            Console.Write(fancyRightMargin + "\n");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static string readText(string str)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            writeText(0, ConsoleColor.Green, ConsoleColor.Black, "");
            string defaultInputLine = fancyLeftMargin + "       " + str;
            Console.Write(defaultInputLine);
            string inputStr;

            inputStr = Console.ReadLine();
            writeText(0, ConsoleColor.Green, ConsoleColor.Black, "");
            Console.BackgroundColor = ConsoleColor.Black;
            if (inputStr != null || inputStr == "")
                return inputStr;
            else return "";
        }
    }
}
