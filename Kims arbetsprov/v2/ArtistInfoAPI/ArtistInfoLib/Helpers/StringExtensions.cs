using System.Globalization;

namespace ArtistInfoLib.Helpers
{
    public static class StringExtensions
    {
        public static string SubstringAfter(this string source, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return source;
            }
            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;
            var index = compareInfo.IndexOf(source, value, CompareOptions.Ordinal);
            return index < 0 ? string.Empty : source.Substring(index + value.Length);
        }

        public static string SubstringBefore(this string source, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }
            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;
            var index = compareInfo.IndexOf(source, value, CompareOptions.Ordinal);
            return index < 0 ? string.Empty : source.Substring(0, index);
        }
    }
}
