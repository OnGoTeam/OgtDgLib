using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib.AmmoTypes
{
    [PublicAPI]
    public abstract class BaseAmmotype:AmmoType
    {
        private Nothing _nothing;

        private void InitNothing()
        {
            if (_nothing is null) _nothing = new Nothing();
        }

        protected string GetPath(string asset)
        {
            InitNothing();
            return _nothing.GetPath(asset);
        }
    }
}