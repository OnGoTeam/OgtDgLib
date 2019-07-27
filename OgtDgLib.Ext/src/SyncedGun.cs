#if DEBUG
using DuckGame;
using JetBrains.Annotations;
using OgtDgLib.AmmoTypes;

namespace OgtDgLib.Ext
{
    public abstract class SyncedGun:TypedGun
    {
        
        [UsedImplicitly]
        public StateBinding AtsBinding = new StateBinding(nameof(AmmoTypeSerialized));
        protected SyncedGun(float xval, float yval, SpriteMap smap, int nonSkinFrames) : base(xval, yval, smap, nonSkinFrames)
        {
        }
    }
}
#endif