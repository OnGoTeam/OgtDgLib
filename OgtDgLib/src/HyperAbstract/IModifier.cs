namespace OgtDgLib.HyperAbstract
{
    /// <summary>
    /// Interface for modifiers
    /// </summary>
    public interface IModifier
    {
        /// <summary>
        /// Applies <see cref="IModifier"/> at <see cref="IModifiable"/>
        /// </summary>
        /// <param name="applied"></param>
        void Apply(IModifiable applied);
    }
}