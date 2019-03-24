using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib
{
    /// <inheritdoc />
    /// <summary>
    ///     Empty thing with GetPath
    /// </summary>
    [PublicAPI]
    public sealed class Nothing : Thing
    {
        private readonly Mod _mod;
        /// <summary>
        /// Nothing related to Mod mod; implement mod.LastInstance to use
        /// </summary>
        public Nothing(Mod mod)
        {
            _mod = mod;
        }

        /// <summary>
        /// reimplementation of GetPath
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        public new string GetPath(string asset)
        {
            return _mod.GetPath(asset);
        }
    }
}