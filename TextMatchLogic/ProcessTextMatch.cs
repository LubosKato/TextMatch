using System.Globalization;

namespace TextMatchLogic
{
    public class ProcessTextMatch : IProcessTextMatch
    {
        public string MainText { get; set; }
        public string SubText { get; set; }

        protected const string NoOutput = "There is no output";

        public string Process()
        {
            string result = string.Empty;

            //Check if both inputs are not null or empty and if MainText is longer than the SubText
            if (MainText == null || SubText == null || (MainText.Length < SubText.Length || SubText.Length == 0 || MainText.Length == 0))
                return NoOutput;

            char[] mainTextArray = MainText.ToUpper().ToCharArray();
            char[] subTextArray = SubText.ToUpper().ToCharArray();

            for (int i = 0; i <= MainText.Length - 1; i++)
            {
                if (mainTextArray[i] == subTextArray[0] && i + (subTextArray.Length - 1) <= mainTextArray.Length - 1)
                {
                    int isMatch = 1;
                    int location = i;

                    for (int j = 0; j <= subTextArray.Length - 1; j++)
                    {
                        if (mainTextArray[i + j] != subTextArray[j])
                        {
                            isMatch = isMatch * -1;
                            i = location + j;
                            j = subTextArray.Length - 1;
                        }
                    }

                    if (isMatch == 1)
                    {
                        result += result.Length == 0
                                      ? (location + 1).ToString(CultureInfo.InvariantCulture)
                                      : ", " + (location + 1).ToString(CultureInfo.InvariantCulture);
                        i += subTextArray.Length - 1;
                    }
                }
            }

            return result.Length == 0 ? NoOutput : result;
        }
    }
}
