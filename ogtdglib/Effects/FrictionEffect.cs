using System.Reflection;
using DuckGame;

namespace ogtdglib.Effects
{
    [Obfuscation(Exclude = true, ApplyToMembers = false)]
    public sealed class FrictionEffect:LinkedEffect
    {
        private readonly float _friction;

        public FrictionEffect(Thing owner, Thing linkThing, float friction) : base(owner, linkThing)
        {
            _friction = friction;
        }

        [Obfuscation(Exclude = true)]
        protected override void LinkedStep(Thing linkThing)
        {
            linkThing.hSpeed *= _friction;
            linkThing.vSpeed *= _friction;
        }
    }
}