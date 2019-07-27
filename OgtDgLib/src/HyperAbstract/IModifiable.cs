using System.Collections.Generic;

namespace OgtDgLib.HyperAbstract
{
    /// <summary>
    /// Interface for being applied with <see cref="IModifier"/>s
    /// </summary>
    public interface IModifiable
    {
        /// <summary>
        /// Default modifier
        /// </summary>
        IDefaultModifier DefaultModifier { get; }
        /// <summary>
        /// Non-default modifiers being applied
        /// </summary>
        IEnumerable<IModifier> Modifiers { get; }
    }
}