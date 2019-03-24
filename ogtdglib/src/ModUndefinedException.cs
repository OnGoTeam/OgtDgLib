using System;

namespace ogtdglib
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