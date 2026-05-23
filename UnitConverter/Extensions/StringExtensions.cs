namespace UnitConverter.Extensions
{
    public static class StringExtensions
    {
        public static string ToSentenceCase(this string word)
        {
            if (string.IsNullOrEmpty(word)) return word;
            return char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }
    }
}
