namespace NetCoreExtensions.Security
{
    /// <summary>
    /// String formatting options for <see cref="HashResult"/>.
    /// </summary>
    public enum HashResultFormatting
    {
        /// <summary>All lowercase hex, with no special characters.</summary>
        Lowercase,

        /// <summary>All uppercase hex, with no special characters.</summary>
        Uppercase,

        /// <summary>Base64 representation</summary>
        Base64
    }
}
