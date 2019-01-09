using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib.Effects
{
    [PublicAPI]
    public abstract class Effect
    {
        public bool Decayed { get; protected set; }
        public Thing Owner { get; }
        protected uint Ticks { get; private set; }

        [PublicAPI]
        protected Effect(Thing owner)
        {
            Owner = owner;
        }

        public void Step()
        {
            Ticks += 1;
            OnStep();
        }

        protected abstract void OnStep();
    }
}