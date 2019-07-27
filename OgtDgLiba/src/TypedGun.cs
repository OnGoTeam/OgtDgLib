#if DEBUG
using DuckGame;

namespace OgtDgLib
{
    public abstract class TypedGun:BaseGun
    {
        protected TypedGun(float xval, float yval, SpriteMap smap, int nonSkinFrames) : base(xval, yval, smap, nonSkinFrames)
        {
        }
    }
}
#endif