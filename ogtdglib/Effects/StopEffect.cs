using DuckGame;

namespace ogtdglib.Effects
{
    public sealed class StopEffect:LinkedEffect
    {
        private readonly float _x;
        private readonly float _y;
        private readonly uint _ttd;

        public StopEffect(Thing owner, Thing linkThing, uint ttd) : base(owner, linkThing)
        {
            _x = linkThing.x;
            _y = linkThing.y;
            _ttd = ttd;
        }

        protected override void LinkedStep(Thing linkThing)
        {
            linkThing.hSpeed = 0f;
            linkThing.vSpeed = 0f;
            linkThing.x = _x;
            linkThing.y = _y;
            if (Ticks > _ttd) Decayed = true;
        }
    }
}