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
        /// Compute a SHA1 hash for the input data. 
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha1(this string input)
            => Sha1(input, Encoding.UTF8);

        /// <summary>
        /// Compute a SHA1 hash for the input data.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="encoding">The encoding format of the input</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha1(this string input, Encoding encoding)
            => Sha1(encoding.GetBytes(input));

        /// <summary>
        /// Compute a SHA1 hash for the input data. 
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
        /// Compute a SHA256 hash for the input data. 
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha256(this string input)
            => Sha256(input, Encoding.UTF8);

        /// <summary>
        /// Compute a SHA256 hash for the input data. 
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="encoding">The encoding format of the input</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha256(this string input, Encoding encoding)
            => Sha256(encoding.GetBytes(input));

        /// <summary>
        /// Compute a SHA256 hash for the input data.
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
        /// Compute a SHA384 hash for the input data. 
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha384(this string input)
            => Sha384(input, Encoding.UTF8);

        /// <summary>
        /// Compute a SHA384 hash for the input data. 
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="encoding">The encoding format of the input</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha384(this string input, Encoding encoding)
            => Sha384(encoding.GetBytes(input));

        /// <summary>
        /// Compute a SHA384 hash for the input data. 
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
        /// Compute a SHA512 hash for the input data. 
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha512(this string input)
            => Sha512(input, Encoding.UTF8);

        /// <summary>
        /// Compute a SHA512 hash for the input data.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="encoding">The encoding format of the input</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult Sha512(this string input, Encoding encoding)
            => Sha512(encoding.GetBytes(input));

        /// <summary>
        /// Compute a SHA512 hash for the input data.
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

        /// <summary>
        /// Computes a HMAC-SHA1 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <param name="key">The key to use, assumed to be UTF-8.</param>
        public static HashResult HmacSha1(this string input, string key)
            => HmacSha1(input, key, Encoding.UTF8);

        /// <summary>
        /// Computes a HMAC-SHA1 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="key">The key to use</param>
        /// <param name="encoding">The encoding format of the input and key</param>
        public static HashResult HmacSha1(this string input, string key, Encoding encoding)
            => HmacSha1(encoding.GetBytes(input), encoding.GetBytes(key));

        /// <summary>
        /// Computes a HMAC-SHA1 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <param name="key">The raw key to use</param>
        public static HashResult HmacSha1(this string input, byte[] key)
            => HmacSha1(input, key, Encoding.UTF8);

        /// <summary>
        /// Computes a HMAC-SHA1 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="key">The raw key to use</param>
        /// <param name="encoding">The encoding format of the input</param>
        public static HashResult HmacSha1(this string input, byte[] key, Encoding encoding)
            => HmacSha1(encoding.GetBytes(input), key);

        /// <summary>
        /// Computes a HMAC-SHA1 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <param name="key">The key to use, assumed to be UTF-8.</param>
        public static HashResult HmacSha1(this byte[] input, string key)
            => HmacSha1(input, Encoding.UTF8.GetBytes(key));

        /// <summary>
        /// Computes a HMAC-SHA1 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <param name="key">The raw key to use</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult HmacSha1(this byte[] input, byte[] key)
        {
            using (var hash = new HMACSHA1(key))
            {
                return new HashResult(hash.ComputeHash(input));
            }
        }

        /// <summary>
        /// Computes a HMAC-SHA256 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <param name="key">The key to use, assumed to be UTF-8.</param>
        public static HashResult HmacSha256(this string input, string key)
            => HmacSha256(input, key, Encoding.UTF8);

        /// <summary>
        /// Computes a HMAC-SHA256 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="key">The key to use</param>
        /// <param name="encoding">The encoding format of the input and key</param>
        public static HashResult HmacSha256(this string input, string key, Encoding encoding)
            => HmacSha256(encoding.GetBytes(input), encoding.GetBytes(key));

        /// <summary>
        /// Computes a HMAC-SHA256 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <param name="key">The raw key to use</param>
        public static HashResult HmacSha256(this string input, byte[] key)
            => HmacSha256(input, key, Encoding.UTF8);

        /// <summary>
        /// Computes a HMAC-SHA256 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="key">The raw key to use</param>
        /// <param name="encoding">The encoding format of the input</param>
        public static HashResult HmacSha256(this string input, byte[] key, Encoding encoding)
            => HmacSha256(encoding.GetBytes(input), key);

        /// <summary>
        /// Computes a HMAC-SHA256 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <param name="key">The key to use, assumed to be UTF-8.</param>
        public static HashResult HmacSha256(this byte[] input, string key)
            => HmacSha256(input, Encoding.UTF8.GetBytes(key));

        /// <summary>
        /// Computes a HMAC-SHA256 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <param name="key">The raw key to use</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult HmacSha256(this byte[] input, byte[] key)
        {
            using (var hash = new HMACSHA256(key))
            {
                return new HashResult(hash.ComputeHash(input));
            }
        }

        /// <summary>
        /// Computes a HMAC-SHA384 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <param name="key">The key to use, assumed to be UTF-8.</param>
        public static HashResult HmacSha384(this string input, string key)
            => HmacSha384(input, key, Encoding.UTF8);

        /// <summary>
        /// Computes a HMAC-SHA384 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="key">The key to use</param>
        /// <param name="encoding">The encoding format of the input and key</param>
        public static HashResult HmacSha384(this string input, string key, Encoding encoding)
            => HmacSha384(encoding.GetBytes(input), encoding.GetBytes(key));

        /// <summary>
        /// Computes a HMAC-SHA384 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <param name="key">The raw key to use</param>
        public static HashResult HmacSha384(this string input, byte[] key)
            => HmacSha384(input, key, Encoding.UTF8);

        /// <summary>
        /// Computes a HMAC-SHA384 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="key">The raw key to use</param>
        /// <param name="encoding">The encoding format of the input</param>
        public static HashResult HmacSha384(this string input, byte[] key, Encoding encoding)
            => HmacSha384(encoding.GetBytes(input), key);

        /// <summary>
        /// Computes a HMAC-SHA384 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <param name="key">The key to use, assumed to be UTF-8.</param>
        public static HashResult HmacSha384(this byte[] input, string key)
            => HmacSha384(input, Encoding.UTF8.GetBytes(key));

        /// <summary>
        /// Computes a HMAC-SHA384 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <param name="key">The raw key to use</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult HmacSha384(this byte[] input, byte[] key)
        {
            using (var hash = new HMACSHA384(key))
            {
                return new HashResult(hash.ComputeHash(input));
            }
        }

        /// <summary>
        /// Computes a HMAC-SHA512 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <param name="key">The key to use, assumed to be UTF-8.</param>
        public static HashResult HmacSha512(this string input, string key)
            => HmacSha512(input, key, Encoding.UTF8);

        /// <summary>
        /// Computes a HMAC-SHA512 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="key">The key to use</param>
        /// <param name="encoding">The encoding format of the input and key</param>
        public static HashResult HmacSha512(this string input, string key, Encoding encoding)
            => HmacSha512(encoding.GetBytes(input), encoding.GetBytes(key));

        /// <summary>
        /// Computes a HMAC-SHA512 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash, assumed to be UTF-8.</param>
        /// <param name="key">The raw key to use</param>
        public static HashResult HmacSha512(this string input, byte[] key)
            => HmacSha512(input, key, Encoding.UTF8);

        /// <summary>
        /// Computes a HMAC-SHA512 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The input string to hash</param>
        /// <param name="key">The raw key to use</param>
        /// <param name="encoding">The encoding format of the input</param>
        public static HashResult HmacSha512(this string input, byte[] key, Encoding encoding)
            => HmacSha512(encoding.GetBytes(input), key);

        /// <summary>
        /// Computes a HMAC-SHA512 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <param name="key">The key to use, assumed to be UTF-8.</param>
        public static HashResult HmacSha512(this byte[] input, string key)
            => HmacSha512(input, Encoding.UTF8.GetBytes(key));

        /// <summary>
        /// Computes a HMAC-SHA512 hash for the input data, using the specified key.
        /// </summary>
        /// <param name="input">The raw input data to hash</param>
        /// <param name="key">The raw key to use</param>
        /// <returns>Unix format hex string of the hash</returns>
        public static HashResult HmacSha512(this byte[] input, byte[] key)
        {
            using (var hash = new HMACSHA512(key))
            {
                return new HashResult(hash.ComputeHash(input));
            }
        }
    }
}