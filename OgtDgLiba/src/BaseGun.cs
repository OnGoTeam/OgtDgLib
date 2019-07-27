using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib
{
    /// <summary>
    /// Basic gun implementing framesync
    /// </summary>
    public abstract class BaseGun:Gun
    {
        /// <summary>
        /// SpriteMap being synced as _graphic
        /// </summary>
        [PublicAPI]
        protected readonly SpriteMap Smap;

        /// <summary>
        /// External Smap._frame access, for syncing
        /// </summary>
        [PublicAPI]
        public int FrameId
        {
            get => Smap._frame;
            set => Smap._frame = value;
        }
        /// <summary>
        /// Skin Id
        /// </summary>
        [PublicAPI]
        protected int SkinId
        {
            get => FrameId % _nonSkinFrames;
            set => FrameId = NsfId * _nonSkinFrames + value;
        }
        /// <summary>
        /// Non-skin Id (state id)
        /// </summary>
        [PublicAPI]
        protected int NsfId
        {
            get => FrameId / _nonSkinFrames;
            set => FrameId = value * _nonSkinFrames + SkinId;
        }
        private readonly int _nonSkinFrames;
        /// <summary>
        /// To be implemented as name to frame mapping
        /// </summary>
        [PublicAPI]
        public virtual string Skin
        {
            set
            {
                if (value == "default") SkinId = 0;
            }
        }
        /// <summary>
        /// FrameId binding
        /// </summary>
        [UsedImplicitly]
        public StateBinding FrameBinding = new StateBinding(nameof(FrameId));

        /// <inheritdoc />
        protected BaseGun(float xval, float yval, SpriteMap smap, int nonSkinFrames) : base(xval, yval)
        {
            Smap = smap;
            _nonSkinFrames = nonSkinFrames;
            _graphic = Smap;
        }
    }
}