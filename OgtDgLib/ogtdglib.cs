using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib
{
    [PublicAPI]
    public class OgtDgLib:Mod
    {
        public OgtDgLib()
        {
            Debug.Log("OgtDgLib loading");
        }

        public override Priority priority => Priority.Highest;
    }
}