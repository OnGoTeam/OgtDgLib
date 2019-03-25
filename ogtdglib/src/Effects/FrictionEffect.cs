using DuckGame;

namespace OgtDgLib.Effects
{
    /// <inheritdoc />
    /// <summary>
    ///     Effect which multiplies speed of _linkThing by _friction
    /// </summary>
    public sealed class FrictionEffect : LinkedEffect
    {
        private readonly float _friction;

        /// <inheritdoc />
        /// <summary>
        ///     FrictionEffect with Owner owner on (at) _linkThing linkThing by _friction friction
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="linkThing"></param>
        /// <param name="friction"></param>
        public FrictionEffect(Thing owner, Thing linkThing, float friction) : base(owner, linkThing)
        {
            _friction = friction;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Multiplies speed of _linkThing by _friction
        /// </summary>
        /// <param name="linkThing"></param>
        protected override void LinkedStep(Thing linkThing)
        {
            linkThing.hSpeed *= _friction;
            linkThing.vSpeed *= _friction;
        }
    }
}