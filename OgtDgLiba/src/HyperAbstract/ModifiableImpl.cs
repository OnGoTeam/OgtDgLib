using JetBrains.Annotations;

namespace OgtDgLib.HyperAbstract
{
    /// <summary>
    /// Implementation of <see cref="IModifiable"/> and <see cref="IModifier"/>
    /// </summary>
    [PublicAPI]
    public static class ModifiableImpl
    {
        /// <summary>
        /// Appliance of <see cref="IModifiable"/>'s <see cref="IModifier"/>s
        /// </summary>
        /// <param name="modifiable"></param>
        public static void Apply(IModifiable modifiable)
        {
            modifiable.DefaultModifier.Apply(modifiable);
            foreach (var modifier in modifiable.Modifiers)
            {
                modifier.Apply(modifiable);
            }
        }
    }
}