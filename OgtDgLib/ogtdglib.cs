using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib
{
    /// <inheritdoc />
    /// <summary>
    /// Class for using lib as Mod
    /// </summary>
    [PublicAPI]
    public class OgtDgLib:Mod
    {
        /// <inheritdoc />
        /// <summary>
        /// Constructor for Debug.Log
        /// </summary>
        public OgtDgLib()
        {
            Debug.Log("OgtDgLib loading");
        }

        /// <inheritdoc />
        /// <summary>
        /// Loads before 
        /// </summary>
        public override Priority priority => Priority.Highest;
    }
}