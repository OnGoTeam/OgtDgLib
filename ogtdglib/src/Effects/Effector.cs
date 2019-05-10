using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib.Effects
{
    [PublicAPI]
    internal sealed class Effector : IAutoUpdate
    {
        public StateBinding EffectBinding = new StateBinding(nameof(ItsEffect));
        public Effect ItsEffect;

        internal Effector(Effect itsEffect)
        {
            ItsEffect = itsEffect;
            AutoUpdatables.Add(this);
        }

        private void Step()
        {
            ItsEffect.Step();
        }

        public void Update()
        {
            if (!ItsEffect.Decayed)
                Step();
        }
    }
}