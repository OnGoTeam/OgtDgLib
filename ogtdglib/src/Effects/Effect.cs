using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib.Effects
{
    /// <summary>
    ///     Applies OnStep every Step until Decayed
    /// </summary>
    [PublicAPI]
    public abstract class Effect
    {
        /// <summary>
        ///     Effect with Owner owner
        /// </summary>
        /// <param name="owner"></param>
        protected Effect(Thing owner)
        {
            Owner = owner;
        }

        /// <summary>
        ///     Decayed should be used is OnStep to check if Effect shouldn't be applied
        /// </summary>
        public bool Decayed { get; protected set; }

        /// <summary>
        ///     Owner is the thing which made this effect
        /// </summary>
        public Thing Owner { get; }

        /// <summary>
        ///     Ticks is how many times Step was made
        /// </summary>
        protected uint Ticks { get; private set; }

        /// <summary>
        ///     Step is what's actually called by Effector
        /// </summary>
        public void Step()
        {
            Ticks += 1;
            OnStep();
        }

        /// <summary>
        ///     Effect body is in OnStep which is applied every Step
        /// </summary>
        protected abstract void OnStep();

        /// <summary>
        ///     Returns Effector corresponding to your Effect which calls Step every Update
        /// </summary>
        /// <param name="effect"></param>
        /// <returns></returns>
        public static Thing Apply(Effect effect)
        {
            return new Effector(effect);
        }
    }
}