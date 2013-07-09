using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace TextMatch
{
    public class CommandLineHelper
    {
        [Option("text", Required = true, HelpText = "String to find matches within.")]
        public string Text { get; set; }

        [ValueList(typeof(List<string>))]
        public IList<string> RestOfText { get; set; }

        [Option("subtext", Required = true, HelpText = "String to search for.")]
        public string Subtext { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
                                      (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}