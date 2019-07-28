#if DEBUG
using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib.Ext
{
    public abstract class SyncedGun:TypedGun
    {
        [UsedImplicitly]
        public BitBuffer AtSs
        {
            get => _ammoType is SyncedAT ? new BitBuffer() : AmmoTypeSerialized;
            set
            {
                if (_ammoType is SyncedAT) return;
                if (value == new BitBuffer()) return;
                AmmoTypeSerialized = value;
            }
        }
        [UsedImplicitly]
        public StateBinding AtsBinding = new StateBinding(nameof(AtSs));
        protected SyncedGun(float xval, float yval, SpriteMap smap, int nonSkinFrames) : base(xval, yval, smap, nonSkinFrames)
        {
        }
    }
}
#endif