using DuckGame;

namespace OgtDgLib.Effects
{
    /// <inheritdoc />
    /// <summary>
    ///     Applies LinkedStep on (at) _linkThing every Step until Decayed
    /// </summary>
    public abstract class LinkedEffect : Effect
    {
        private readonly Thing _linkThing;

        /// <inheritdoc />
        /// <summary>
        ///     LinkedEffect with Owner owner on (at) _linkThing linkThing
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="linkThing"></param>
        protected LinkedEffect(Thing owner, Thing linkThing) : base(owner)
        {
            _linkThing = linkThing;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Applies LinkedStep on (at) _linkThing if it's presented
        /// </summary>
        protected sealed override void OnStep()
        {
            if (_linkThing == null || _linkThing is MaterialThing materialThing && materialThing._destroyed)
            {
                Decayed = true;
                return;
            }

            LinkedStep(_linkThing);
        }

        /// <summary>
        ///     Effect body is in LinkedStep which is applied on (at) _linkThing every Step
        /// </summary>
        /// <param name="linkThing"></param>
        protected abstract void LinkedStep(Thing linkThing);
    }
}