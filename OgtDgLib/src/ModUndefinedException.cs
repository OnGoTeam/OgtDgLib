using System;

namespace OgtDgLib
{
    /// <inheritdoc />
    [Obsolete]
    public class ModUndefinedException:Exception
    {
        /// <inheritdoc />
        public ModUndefinedException(string message) : base(message)
        {
        }
    }
}