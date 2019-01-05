using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetCoreExtensions.Regex
{
    /// <summary>
    /// Regular Expression related methods.
    /// </summary>
    public static class RegexExtensions
    {
        /// <inheritdoc cref="System.Text.RegularExpressions.Regex.Match(string,string)"/>
        public static Match Match(this string input, string pattern)
            => System.Text.RegularExpressions.Regex.Match(input, pattern);

        /// <inheritdoc cref="System.Text.RegularExpressions.Regex.Match(string,string,RegexOptions)"/>
        public static Match Match(this string input, string pattern, RegexOptions options)
            => System.Text.RegularExpressions.Regex.Match(input, pattern, options);

        /// <summary>
        /// Calls <see cref="System.Text.RegularExpressions.Regex.Match(string,string)"/>, sending back
        /// the match result as an output parameter, and returning true
        /// if <see cref="System.Text.RegularExpressions.Group.Success">Match.Success</see>.
        /// </summary>
        /// <param name="input">The string to search for a match</param>
        /// <param name="pattern">The regular expression pattern to match</param>
        /// <param name="match">The return value of <see cref="System.Text.RegularExpressions.Regex.Match(string,string)"/></param>
        public static bool TryMatch(this string input, string pattern, out Match match)
        {
            match = System.Text.RegularExpressions.Regex.Match(input, pattern);
            return match.Success;
        }

        /// <summary>
        /// Calls <see cref="System.Text.RegularExpressions.Regex.Match(string,string)"/>, sending back
        /// the match result as an output parameter, and returning true
        /// if <see cref="System.Text.RegularExpressions.Group.Success">Match.Success</see>.
        /// </summary>
        /// <param name="input">The string to search for a match</param>
        /// <param name="pattern">The regular expression pattern to match</param>
        /// <param name="options">A bitwise combination of the options for matching</param>
        /// <param name="match">The return value of <see cref="System.Text.RegularExpressions.Regex.Match(string,string)"/></param>
        public static bool TryMatch(this string input, string pattern, RegexOptions options, out Match match)
        {
            match = System.Text.RegularExpressions.Regex.Match(input, pattern, options);
            return match.Success;
        }

        /// <inheritdoc cref="System.Text.RegularExpressions.Regex.Matches(string,string)"/>
        public static IEnumerable<Match> Matches(this string input, string pattern)
            => System.Text.RegularExpressions.Regex.Matches(input, pattern)
                .ToEnumerable();

        /// <inheritdoc cref="System.Text.RegularExpressions.Regex.Matches(string,string,RegexOptions)"/>
        public static IEnumerable<Match> Matches(this string input, string pattern, RegexOptions options)
            => System.Text.RegularExpressions.Regex.Matches(input, pattern, options)
                .ToEnumerable();

        /// <summary>
        /// Converts a specialized <see cref="MatchCollection"/> into an easier to consume
        /// <see cref="IEnumerable{Match}"/>.
        /// </summary>
        /// <param name="collection"></param>
        public static IEnumerable<Match> ToEnumerable(this MatchCollection collection)
        {
            foreach (Match match in collection) yield return match;
        }
    }
}