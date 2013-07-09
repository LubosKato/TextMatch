using System.Text;
using NUnit.Framework;
using TextMatchLogic;

namespace TextMatchTests
{
    [TestFixture]
    public class TestSetup
    {
        public const string validMainText = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";

        public const string subTextValid = "polly";
        public const string subTextUpperCaseValid = "POLLY";
        public const string subTextValid1 = "ll";
        public const string subTextInvalid = "X";
        public const string subTextInvalid1 = "Polx";

        public IProcessTextMatch logic;
        public string BigMainText;

        [SetUp]
        public virtual void Setup()
        {
            logic = new ProcessTextMatch();
            logic.MainText = validMainText;
            BigMainText = SetupBigString();
        }

        private string SetupBigString()
        {
            var myStringBuilder = new StringBuilder(validMainText);
            for (int i = 0; i < 100; i++)
            {
                myStringBuilder.Append(validMainText + " ");
            }
            return myStringBuilder.ToString();
        }
    }
}