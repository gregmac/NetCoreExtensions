using System;
using System.Linq;

namespace NetCoreExtensions.Security
{
    /// <summary>
    /// Result of a hashing function (eg: SHA family)
    /// </summary>
    public class HashResult
    {
        /// <summary>
        /// Create a new hash result from a byte array.
        /// </summary>
        /// <param name="hash"></param>
        public HashResult(byte[] hash)
        {
            Bytes = hash;
        }

        /// <summary>
        /// Raw byte data representing the hash
        /// </summary>
        public byte[] Bytes { get; }

        /// <summary>
        /// Convert to <see cref="HashResultFormatting.Lowercase">lower-case hex string</see>.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => ToString(HashResultFormatting.Lowercase);

        /// <summary>
        /// Convert to a string format
        /// </summary>
        /// <param name="formatting"></param>
        /// <returns></returns>
        public string ToString(HashResultFormatting formatting)
        {
            switch (formatting)
            {
                case HashResultFormatting.Base64:
                    return Convert.ToBase64String(Bytes);
                case HashResultFormatting.Uppercase:
                    return string.Concat(Bytes.Select(x => x.ToString("X2")));
                case HashResultFormatting.Lowercase:
                default:
                    return string.Concat(Bytes.Select(x => x.ToString("x2")));
            }
        }

        /// <summary>
        /// Implicit string conversion, converting to <see cref="HashResultFormatting.Lowercase">lower-case hex string</see>.
        /// </summary>
        /// <param name="v"></param>
        public static implicit operator string(HashResult v) => v.ToString(HashResultFormatting.Lowercase);
    }
}
