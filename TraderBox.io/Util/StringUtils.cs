using System;
using System.Linq;

namespace TraderBox.io.Util
{
    public static class StringUtils
    {
        public static string GetRandomString(int length)
        {
            Random random = new Random();
            var chars = "qwertyuiopasdfghjkzxcvbnm";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)])
                .ToArray());
        }
    }
}
