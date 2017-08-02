using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_common_string
{
    public static class StringExtensions
    {


        public static IEnumerable<string> GetMostCommonSubstrings(this IList<string> strings)
        {
            if (strings == null)
                throw new ArgumentNullException("strings");
            if (!strings.Any() || strings.Any(s => string.IsNullOrEmpty(s)))
                throw new ArgumentException("No string must be empty", "strings");

            var allSubstrings = new List<List<string>>();
            for (int i = 0; i < strings.Count; i++)
            {
                var substrings = new List<string>();
                string str = strings[i];
                for (int c = 0; c < str.Length - 1; c++)
                {
                    for (int cc = 1; c + cc <= str.Length; cc++)
                    {
                        string substr = str.Substring(c, cc);
                        if (allSubstrings.Count < 1 || allSubstrings.Last().Contains(substr))
                            substrings.Add(substr);
                    }
                }
                allSubstrings.Add(substrings);
            }
            if (allSubstrings.Last().Any())
            {
                var mostCommon = allSubstrings.Last()
                    .GroupBy(str => str)
                    .OrderByDescending(g => g.Key.Length)
                    .ThenByDescending(g => g.Count())
                    .Select(g => g.Key);
                return mostCommon;
            }
            return Enumerable.Empty<string>();
        }

        public static IEnumerable<IEnumerable<T>> Transpose<T>(this IEnumerable<IEnumerable<T>> source)
        {
            var enumerators = source.Select(e => e.GetEnumerator()).ToArray();
            try
            {
                while (enumerators.All(e => e.MoveNext()))
                {
                    yield return enumerators.Select(e => e.Current).ToArray();
                }
            }
            finally
            {
                Array.ForEach(enumerators, e => e.Dispose());
            }
        }

    }
}
