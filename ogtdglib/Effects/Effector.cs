using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib.Effects
{
    [PublicAPI]
    public sealed class Effector:Thing
    {
        public Effect ItsEffect;
        public StateBinding EffectBinding = new StateBinding(nameof(ItsEffect));

        public Effector(Effect itsEffect)
        {
            ItsEffect = itsEffect;
            owner = ItsEffect.Owner;
        }

        public override void Initialize()
        {
            Step();
        }

        public void Step()
        {
            ItsEffect.Step();
        }

        public override void Update()
        {
            if (!ItsEffect.Decayed)
            {
                ItsEffect.Step();
            }
            else
            {
                Level.Remove(this);
            }
        }
    }
}