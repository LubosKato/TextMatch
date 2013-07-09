using System;
using CommandLine;

namespace TextMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = String.Empty;
            string subText = String.Empty;

            var options = new CommandLineHelper();
            if (Parser.Default.ParseArguments(args, options))
            {
                // Values are available here
                text = options.Text + " " + String.Join<string>(" ", options.RestOfText);
                subText = options.Subtext;
            }

            if (text.Length > 0 && subText.Length > 0)
            {
                var logic = new TextMatchLogic.ProcessTextMatch { MainText = text, SubText = subText };
                Console.WriteLine(logic.Process());
                Console.ReadLine();
            }
            else
            {
                options.GetUsage();
            }
        }
    }
}
