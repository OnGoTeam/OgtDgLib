using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib
{
    /// <summary>
    /// Physical equivalent to nothing
    /// </summary>
    [PublicAPI]
    public sealed class MaterialDotP : PhysicsObject
    {
        /// <inheritdoc />
        public MaterialDotP()
        {
            thickness = -1;
        }

        /// <inheritdoc />
        public MaterialDotP(float xval, float yval) : base(xval, yval)
        {
            thickness = -1;
        }
    }
}