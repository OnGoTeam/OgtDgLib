using System;
using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib
{
    /// <inheritdoc />
    /// <summary>
    ///     Empty thing with GetPath
    /// </summary>
    [PublicAPI]
    [Obsolete]
    public sealed class Nothing <T> : Thing where T : Mod
    {
        /// <summary>
        /// reimplementation of GetPath
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        public new string GetPath(string asset)
        {
            return Mod.GetPath<T>(asset);
        }
    }
}