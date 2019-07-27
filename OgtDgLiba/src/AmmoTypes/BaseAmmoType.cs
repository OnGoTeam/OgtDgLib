#if DEBUG
using System;
using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib.AmmoTypes
{
    /// <summary>
    ///     AmmoType with GetPath
    /// </summary>
    [PublicAPI]
    [Obsolete]
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
    [PublicAPI]
    public abstract class BaseAmmoType: AmmoType
    {
        public static BinaryClassChunk SerializeAt(AmmoType at)
        {
            var binaryClassChunk = new BinaryClassChunk();
            binaryClassChunk.AddProperty("bulletSpeed", at.bulletSpeed);
            binaryClassChunk.AddProperty("speedVariation", at.speedVariation);
            binaryClassChunk.AddProperty("bulletLength", at.bulletLength);
            binaryClassChunk.AddProperty("bulletThickness", at.bulletThickness);
            binaryClassChunk.AddProperty("deadly", at.deadly);
            binaryClassChunk.AddProperty("impactPower", at.impactPower);
            // binaryClassChunk.AddProperty("bulletType", at.bulletType);
            binaryClassChunk.AddProperty("accuracy", at.accuracy);
            binaryClassChunk.AddProperty("range", at.range);
            binaryClassChunk.AddProperty("rangeVariation", at.rangeVariation);
            binaryClassChunk.AddProperty("penetration", at.penetration);
            binaryClassChunk.AddProperty("rebound", at.rebound);
            binaryClassChunk.AddProperty("affectedByGravity", at.affectedByGravity);
            binaryClassChunk.AddProperty("barrelAngleDegrees", at.barrelAngleDegrees);
            binaryClassChunk.AddProperty("immediatelyDeadly", at.immediatelyDeadly);
            binaryClassChunk.AddProperty("weight", at.weight);
            binaryClassChunk.AddProperty("combustable", at.combustable);
            // TODO: COLOR
            // binaryClassChunk.AddProperty("", );
            return binaryClassChunk;
        }

        public static bool DeserializeAt(BinaryClassChunk node, AmmoType at)
        {
            at.bulletSpeed = node.GetProperty<float>("bulletSpeed");
            at.speedVariation = node.GetProperty<float>("speedVariation");
            at.bulletLength = node.GetProperty<float>("bulletLength");
            at.bulletThickness = node.GetProperty<float>("bulletThickness");
            at.deadly = node.GetProperty<bool>("deadly");
            at.impactPower = node.GetProperty<float>("impactPower");
            // at.bulletType = node.GetProperty<Type>("bulletType");
            at.accuracy = node.GetProperty<float>("accuracy");
            at.range = node.GetProperty<float>("range");
            at.rangeVariation = node.GetProperty<float>("rangeVariation");
            at.penetration = node.GetProperty<float>("penetration");
            at.rebound = node.GetProperty<bool>("rebound");
            at.affectedByGravity = node.GetProperty<bool>("affectedByGravity");
            at.barrelAngleDegrees = node.GetProperty<float>("barrelAngleDegrees");
            at.immediatelyDeadly = node.GetProperty<bool>("immediatelyDeadly");
            at.weight = node.GetProperty<float>("weight");
            at.combustable = node.GetProperty<bool>("combustable");
            // TODO: COLOR
            //  = node.GetProperty<>("");
            return true;
        }
    }
}
#endif