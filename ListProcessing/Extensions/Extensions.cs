using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListProcessing.Extensions
{
    public static class Extensions
    {
        public static string ToTitleCase(this string word)
        {
            char firstLetter = word[0];
            if (char.IsLower(firstLetter))
            {
                firstLetter = char.ToUpperInvariant(firstLetter);
            }

            return firstLetter + string.Join("",  word.Skip(1));
        }
    }
}
