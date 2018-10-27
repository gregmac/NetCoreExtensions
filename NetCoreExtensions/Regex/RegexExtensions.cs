using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetCoreExtensions.Regex
{
    public static class RegexExtensions
    {
        /// <inheritdoc cref="Regex.Match(string,string)"/>
        public static Match Match(this string input, string pattern)
            => System.Text.RegularExpressions.Regex.Match(input, pattern);

        /// <inheritdoc cref="Regex.Match(string,string,RegexOptions)"/>
        public static Match Match(this string input, string pattern, RegexOptions options)
            => System.Text.RegularExpressions.Regex.Match(input, pattern, options);

        /// <inheritdoc cref="Regex.Match(string,string)"/>
        /// <summary>
        /// Calls <see cref="Regex.Match(string,string)"/>, sending back
        /// the match result as an output parameter, and returning true
        /// if <see cref="System.Text.RegularExpressions.Match.Success"/>.
        /// </summary>
        /// <param name="match">The return value of <see cref="Regex.Match(string,string)"/></param>
        /// <returns></returns>
        public static bool TryMatch(this string input, string pattern, out Match match)
        {
            match = System.Text.RegularExpressions.Regex.Match(input, pattern);
            return match.Success;
        }
        
        /// <inheritdoc cref="Regex.Match(string,string,RegexOptions)"/>
        /// <summary>
        /// Calls <see cref="Regex.Match(string,string)"/>, sending back
        /// the match result as an output parameter, and returning true
        /// if <see cref="System.Text.RegularExpressions.Match.Success"/>.
        /// </summary>
        /// <param name="match">The return value of <see cref="Regex.Match(string,string)"/></param>
        /// <returns></returns>
        public static bool TryMatch(this string input, string pattern, RegexOptions options, out Match match)
        {
            match = System.Text.RegularExpressions.Regex.Match(input, pattern, options);
            return match.Success;
        }

        /// <inheritdoc cref="Regex.Matches(string,string)"/>
        public static IEnumerable<Match> Matches(this string input, string pattern)
            => System.Text.RegularExpressions.Regex.Matches(input, pattern)
                .ToEnumerable();
        
        /// <inheritdoc cref="Regex.Matches(string,string,RegexOptions)"/>
        public static IEnumerable<Match> Matches(this string input, string pattern, RegexOptions options)
            => System.Text.RegularExpressions.Regex.Matches(input, pattern, options)
                .ToEnumerable();

        /// <summary>
        /// Converts a specialized <see cref="MatchCollection"/> into an easier to consume
        /// <see cref="IEnumerable{Match}"/>.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IEnumerable<Match> ToEnumerable(this MatchCollection collection)
        {
            foreach (Match match in collection) yield return match;
        }

        
    }
}