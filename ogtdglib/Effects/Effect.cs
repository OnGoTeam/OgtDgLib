using System.Reflection;
using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib.Effects
{
    [PublicAPI]
    [Obfuscation(Exclude = true, ApplyToMembers = false)]
    public abstract class Effect
    {
        public bool Decayed { get; protected set; }
        public Thing Owner { get; }
        protected uint Ticks { get; private set; }
        
        protected Effect(Thing owner)
        {
            Owner = owner;
        }

        public void Step()
        {
            Ticks += 1;
            OnStep();
        }

        [Obfuscation(Exclude = true)]
        protected abstract void OnStep();

        [Obfuscation(Exclude = true)]
        public static Thing Apply(Effect effect)
        {
            return new Effector(effect);
        }
    }
}