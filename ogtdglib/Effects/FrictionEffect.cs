using DuckGame;

namespace ogtdglib.Effects
{
    public sealed class FrictionEffect:LinkedEffect
    {
        private readonly float _friction;

        public FrictionEffect(Thing owner, Thing linkThing, float friction) : base(owner, linkThing)
        {
            _friction = friction;
        }

        protected override void LinkedStep(Thing linkThing)
        {
            linkThing.hSpeed *= _friction;
            linkThing.vSpeed *= _friction;
        }
    }
}