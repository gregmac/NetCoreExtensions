using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NetCoreExtensions.Security
{
    /// <summary>
    /// Extensions for doing one-way hashing functions (SHA)
    /// </summary>
    public static class HashExtensions
    {
        /// <summary>
        /// Compute a SHA1 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The input string to test, assumed to be UTF-8.</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha1(this string input)
            => Sha1(input, Encoding.UTF8);
        
        /// <summary>
        /// Compute a SHA1 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The input string to test</param>
        /// <param name="encoding">The encoding format of the input</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha1(this string input, Encoding encoding)
            => Sha1(encoding.GetBytes(input));
        
        /// <summary>
        /// Compute a SHA1 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha1(this byte[] input)
        {
            using (var hash = SHA1.Create())
            {
                return new HashResult(hash.ComputeHash(input));
            }
        }

        /// <summary>
        /// Compute a SHA256 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The input string to test, assumed to be UTF-8.</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha256(this string input)
            => Sha256(input, Encoding.UTF8);

        /// <summary>
        /// Compute a SHA256 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The input string to test</param>
        /// <param name="encoding">The encoding format of the input</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha256(this string input, Encoding encoding)
            => Sha256(encoding.GetBytes(input));

        /// <summary>
        /// Compute a SHA256 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha256(this byte[] input)
        {
            using (var hash = SHA256.Create())
            {
                return new HashResult(hash.ComputeHash(input));
            }
        }

        
        /// <summary>
        /// Compute a SHA384 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The input string to test, assumed to be UTF-8.</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha384(this string input)
            => Sha384(input, Encoding.UTF8);

        /// <summary>
        /// Compute a SHA384 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The input string to test</param>
        /// <param name="encoding">The encoding format of the input</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha384(this string input, Encoding encoding)
            => Sha384(encoding.GetBytes(input));

        /// <summary>
        /// Compute a SHA384 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha384(this byte[] input)
        {
            using (var hash = SHA384.Create())
            {
                return new HashResult(hash.ComputeHash(input));
            }
        }

        /// <summary>
        /// Compute a SHA512 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The input string to test, assumed to be UTF-8.</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha512(this string input)
            => Sha512(input, Encoding.UTF8);

        /// <summary>
        /// Compute a SHA512 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The input string to test</param>
        /// <param name="encoding">The encoding format of the input</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha512(this string input, Encoding encoding)
            => Sha512(encoding.GetBytes(input));

        /// <summary>
        /// Compute a SHA512 hash for the input data. Output is a string in unix format
        /// (all hex, lowercase, no special characters).
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha512(this byte[] input)
        {
            using (var hash = SHA512.Create())
            {
                return new HashResult(hash.ComputeHash(input));
            }
        }

    }
}