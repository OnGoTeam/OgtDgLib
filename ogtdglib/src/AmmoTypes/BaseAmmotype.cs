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
        private readonly Thing _nothing;


        /// <summary>
        /// BaseAmmoType for Mod mod
        /// </summary>
        /// <param name="mod"></param>
        protected BaseAmmoType(Mod mod)
        {
            _nothing = new Nothing(mod);
        }

        /// <summary>
        ///     Implements GetPath for AmmoType through Nothing.GetPath
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        protected string GetPath(string asset)
        {
            return (_nothing ?? throw new ModUndefinedException("Error occured while getting Nothing for Mod mod")).GetPath(asset);
        }
    }
}