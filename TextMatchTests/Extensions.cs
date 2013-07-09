namespace TextMatchTests
{
    public static class Extensions
    {
         public static int GetNumberOfOccurences(this string text)
         {
             string[] values = text.Split(',');
             return values.Length;
         }
    }
}