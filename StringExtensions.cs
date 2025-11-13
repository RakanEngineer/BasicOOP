using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    internal static class StringExtensions
    {
        public static string AddString(this string firstWord, string secondWord)
        {
            return $"{firstWord} {secondWord}";
        }
    }
}
