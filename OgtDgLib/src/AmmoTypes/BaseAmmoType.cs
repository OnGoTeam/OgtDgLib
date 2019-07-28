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
        public static BitBuffer SerializeAt(AmmoType at)
        {
            var b = new BitBuffer();
            WriteFull(b, at);
            return new BitBuffer(b.GetBytes());
        }

        public static BitBuffer WriteFull(BitBuffer b, AmmoType at)
        {
            b.Write(at.bulletSpeed);
            b.Write(at.speedVariation);
            b.Write(at.bulletLength);
            b.Write(at.bulletThickness);
            b.Write(at.deadly);
            b.Write(at.impactPower);
            b.Write(at.accuracy);
            b.Write(at.range);
            b.Write(at.rangeVariation);
            b.Write(at.penetration);
            b.Write(at.rebound);
            b.Write(at.affectedByGravity);
            b.Write(at.barrelAngleDegrees);
            b.Write(at.immediatelyDeadly);
            b.Write(at.weight);
            b.Write(at.combustable);
            b.Write(at.bulletColor.r);
            b.Write(at.bulletColor.g);
            b.Write(at.bulletColor.b);
            b.Write(at.bulletColor.a);
            return b;
        }

        public static bool DeserializeAt(BitBuffer b, AmmoType at)
        {
            return ReadFull(b, at);
        }

        public static bool ReadFull(BitBuffer b, AmmoType at)
        {
            at.bulletSpeed = b.ReadFloat();
            at.speedVariation = b.ReadFloat();
            at.bulletLength = b.ReadFloat();
            at.bulletThickness = b.ReadFloat();
            at.deadly = b.ReadBool();
            at.impactPower = b.ReadFloat();
            at.accuracy = b.ReadFloat();
            at.range = b.ReadFloat();
            at.rangeVariation = b.ReadFloat();
            at.penetration = b.ReadFloat();
            at.rebound = b.ReadBool();
            at.affectedByGravity = b.ReadBool();
            at.barrelAngleDegrees = b.ReadFloat();
            at.immediatelyDeadly = b.ReadBool();
            at.weight = b.ReadFloat();
            at.combustable = b.ReadBool();
            at.bulletColor.r = b.ReadByte();
            at.bulletColor.g = b.ReadByte();
            at.bulletColor.b = b.ReadByte();
            at.bulletColor.a = b.ReadByte();
            return true;
        }
    }
}
#endif