using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib.AmmoTypes
{
    /// <summary>
    ///     AmmoType with GetPath
    /// </summary>
    [PublicAPI]
    public abstract class BaseAmmoType : AmmoType
    {
        private Nothing _nothing;

        private void InitNothing()
        {
            if (_nothing is null) _nothing = new Nothing();
        }

        /// <summary>
        ///     Implements GetPath for AmmoType through Nothing.GetPath
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        protected string GetPath(string asset)
        {
            InitNothing();
            return _nothing.GetPath(asset);
        }
    }
}