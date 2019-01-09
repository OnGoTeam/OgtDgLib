using System.Reflection;
using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib.AmmoTypes
{
    [PublicAPI]
    [Obfuscation(Exclude = true, ApplyToMembers = false)]
    public abstract class BaseAmmotype:AmmoType
    {
        private Nothing _nothing;

        private void InitNothing()
        {
            if (_nothing is null) _nothing = new Nothing();
        }

        [Obfuscation(Exclude = true)]
        protected string GetPath(string asset)
        {
            InitNothing();
            return _nothing.GetPath(asset);
        }
    }
}