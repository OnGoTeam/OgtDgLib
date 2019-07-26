using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib
{
    public class BaseGun:Gun
    {
        [PublicAPI]
        protected readonly SpriteMap Smap;

        [PublicAPI]
        public int FrameId
        {
            get => Smap._frame;
            set => Smap._frame = value;
        }
        [PublicAPI]
        protected int SkinId
        {
            get => FrameId % _nonSkinFrames;
            set => FrameId = NsfId * _nonSkinFrames + value;
        }
        [PublicAPI]
        protected int NsfId
        {
            get => FrameId / _nonSkinFrames;
            set => FrameId = value * _nonSkinFrames + SkinId;
        }
        private readonly int _nonSkinFrames;
        public virtual string Skin
        {
            set
            {
                if (value == "default") SkinId = 0;
            }
        }
        [UsedImplicitly]
        public StateBinding FrameBinding = new StateBinding(nameof(FrameId));
        public BaseGun(float xval, float yval, SpriteMap smap, int nonSkinFrames) : base(xval, yval)
        {
            Smap = smap;
            _nonSkinFrames = nonSkinFrames;
            _graphic = Smap;
        }
    }
}