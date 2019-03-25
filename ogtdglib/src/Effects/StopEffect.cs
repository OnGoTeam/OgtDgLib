using DuckGame;

namespace OgtDgLib.Effects
{
    /// <inheritdoc />
    /// <summary>
    ///     Effect which fixates _linkThing at its position until _ttd ticks applied (then decays)
    /// </summary>
    public sealed class StopEffect : LinkedEffect
    {
        private readonly uint _ttd;
        private readonly float _x;
        private readonly float _y;

        /// <inheritdoc />
        /// <summary>
        ///     StopEffect with Owner owner, _linkThing linkThing and _ttd ttd
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="linkThing"></param>
        /// <param name="ttd"></param>
        public StopEffect(Thing owner, Thing linkThing, uint ttd) : base(owner, linkThing)
        {
            _x = linkThing.x;
            _y = linkThing.y;
            _ttd = ttd;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Fixates _linkThing by stopping it (speed=0) and moving it to first position
        /// </summary>
        /// <param name="linkThing"></param>
        protected override void LinkedStep(Thing linkThing)
        {
            linkThing.hSpeed = 0f;
            linkThing.vSpeed = 0f;
            linkThing.x = _x;
            linkThing.y = _y;
            if (Ticks > _ttd) Decayed = true;
        }
    }
}