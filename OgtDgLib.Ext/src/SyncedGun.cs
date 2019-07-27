#if DEBUG
using DuckGame;
using JetBrains.Annotations;
using OgtDgLib.AmmoTypes;

namespace OgtDgLib.Ext
{
    public abstract class SyncedGun:TypedGun
    {
        [UsedImplicitly]
        public BitBuffer AmmoTypeSerialized
        {
            get => BaseAmmoType.SerializeAt(ammoType).Serialize();
            set => BaseAmmoType.DeserializeAt(BinaryClassChunk.FromData<BinaryClassChunk>(value), ammoType);
        }
        [UsedImplicitly]
        public StateBinding AtsBinding = new StateBinding(nameof(AmmoTypeSerialized));
        protected SyncedGun(float xval, float yval, SpriteMap smap, int nonSkinFrames) : base(xval, yval, smap, nonSkinFrames)
        {
        }
    }
}
#endif