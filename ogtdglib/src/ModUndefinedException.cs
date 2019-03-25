using System;

namespace OgtDgLib
{
    /// <inheritdoc />
    public class ModUndefinedException:Exception
    {
        /// <inheritdoc />
        public ModUndefinedException(string message) : base(message)
        {
        }
    }
}