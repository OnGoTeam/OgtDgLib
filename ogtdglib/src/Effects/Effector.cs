using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib.Effects
{
    [PublicAPI]
    internal sealed class Effector : Thing
    {
        public StateBinding EffectBinding = new StateBinding(nameof(ItsEffect));
        public Effect ItsEffect;

        internal Effector(Effect itsEffect)
        {
            ItsEffect = itsEffect;
            owner = ItsEffect.Owner;
        }

        public override void Initialize()
        {
            Step();
        }

        private void Step()
        {
            ItsEffect.Step();
        }

        public override void Update()
        {
            if (!ItsEffect.Decayed)
                ItsEffect.Step();
            else
                Level.Remove(this);
        }
    }
}