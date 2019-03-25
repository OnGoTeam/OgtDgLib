using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib.AmmoTypes
{
    /// <summary>
    ///     AmmoType with GetPath
    /// </summary>
    [PublicAPI]
    public abstract class BaseAmmoType <T> : AmmoType where T:Mod
    {
        /// <summary>
        ///     Implements GetPath for AmmoType through Nothing.GetPath
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        protected string GetPath(string asset)
        {
            return Mod.GetPath<T>(asset);
        }
    }
}