using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib.AmmoTypes
{
    // ReSharper disable once InconsistentNaming
    /// <inheritdoc />
    /// <summary>
    /// Expiremental AT used as stub where you have to use AT but it mustn't affect
    /// </summary>
    [PublicAPI]
    public class PseudoAT<T> : BaseAmmoType<T> where T : Mod
    {
        /// <inheritdoc />
        /// <summary>
        /// Expiremental Pseudo-AmmoType
        /// </summary>
        public PseudoAT()
        {
            bulletThickness = 0f;
            bulletSpeed = 1e-10f;
            range = 0f;
            rangeVariation = 0f;
            speedVariation = 0f;
            bulletLength = 0f;
            deadly = false;
            impactPower = 0f;
            bulletType = null;
            penetration = -1e+10f;
            immediatelyDeadly = false;
        }
    }
}