using System;
using System.Globalization;
using System.Text;

namespace Rezipe.TimeHelpers
{
    public static class CookTimeExtensions
    {
        public static string ToCookTimeDisplay(this TimeSpan cookTime)
        {
            var ret = new StringBuilder();
            if (cookTime.Days > 0)
            {
                ret.AppendFormat(CultureInfo.CurrentCulture, "{0}d", cookTime.Days);
            }
            if (cookTime.Hours > 0)
            {
                if (ret.Length > 0)
                {
                    ret.Append(" ");
                }
                ret.AppendFormat(CultureInfo.CurrentCulture, "{0}h", cookTime.Hours);
            }
            if (cookTime.Minutes > 0)
            {
                if (ret.Length > 0)
                {
                    ret.Append(" ");
                }
                ret.AppendFormat(CultureInfo.CurrentCulture, "{0}m", cookTime.Minutes);
            }
            // Ignore seconds. Recipes aren't specified in seconds.
            if (ret.Length == 0)
            {
                return "unknown";
            }
            return ret.ToString();
        }
    }
}
