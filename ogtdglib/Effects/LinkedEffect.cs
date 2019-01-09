using DuckGame;

namespace ogtdglib.Effects
{
    public abstract class LinkedEffect:Effect
    {
        private readonly Thing _linkThing;

        protected LinkedEffect(Thing owner, Thing linkThing) : base(owner)
        {
            _linkThing = linkThing;
        }

        protected sealed override void OnStep()
        {
            if (_linkThing == null || _linkThing is MaterialThing materialThing && materialThing._destroyed)
            {
                Decayed = true;
                return;
            }
            LinkedStep(_linkThing);
        }

        protected abstract void LinkedStep(Thing linkThing);
    }
}