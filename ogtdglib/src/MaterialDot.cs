using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib
{
    /// <summary>
    /// Material equivalent to Nothing
    /// </summary>
    [PublicAPI]
    public sealed class MaterialDot : MaterialThing
    {
        /// <inheritdoc />
        public MaterialDot(float x, float y) : base(x, y)
        {
            thickness = -1;
        }
    }
}