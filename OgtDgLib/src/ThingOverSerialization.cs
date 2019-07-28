#if DEBUG
using DuckGame;

namespace OgtDgLib
{
    public static class ThingOverSerialization
    {
        public static BitBuffer Serialize(Transform t)
        {
            var b = new BitBuffer();
            b.Write(t.center);
            b.Write(t.scale);
            b.Write(t.alpha);
            b.Write(t.alphaSub);
            return b;
        }
        public static BitBuffer Serialize(Thing t)
        {
            var b = Serialize((Transform)t);
            b.Write(t.enablePhysics);
            b.Write(t.collisionOffset);
            b.Write(t.collisionSize);
            b.Write(t.opaque);
            return b;
        }
        public static BitBuffer Serialize(MaterialThing t)
        {
            var b = Serialize((Thing) t);
            b.Write(t.thickness);
            b.Write(t.breakForce);
            b.Write(t.impactThreshold);
            b.Write(t.weight);
            b.Write(t.impactVolume);
            b.Write(t.burnSpeed);
            b.Write(t.buoyancy);
            b.Write(t.translucent);
            b.Write(t.destructive);
            b.Write(t.onlyCrush);
            b.Write(t.dontCrush);
            b.Write(t.bouncy);
            b.Write(t.flammable);
            return b;
        }

        public static BitBuffer Serialize(PhysicsObject t)
        {
            var b = Serialize((MaterialThing) t);
            b.Write(t.vMax);
            b.Write(t.hMax);
            b.Write(t.friction);
            b.Write(t.frictionMult);
            b.Write(t.airFrictionMult);
            b.Write(t.throwSpeedMultiplier);
            b.Write(t.gravMultiplier);
            b.Write(t.floatMultiplier);
            b.Write(t.specialFrictionMod);
            b.Write(t.frictionMod);
            return b;
        }
        public static BitBuffer Serialize(Bullet t)
        {
            var b = Serialize((Thing) t);
            return b;
        }
        public static BitBuffer Serialize(Holdable t)
        {
            var b = Serialize((PhysicsObject)t);
            b.Write(t.raiseSpeed);
            b.Write(t.canRaise);
            b.Write(t.hoverRaise);
            b.Write(t.hasTrigger);
            b.Write(t.canPickUp);
            b.Write(t.handOffset);
            b.Write(t.holdOffset);
            b.Write(t.ignoreHands);
            b.Write(t.handAngle);
            b.Write(t.handFlip);
            return b;
        }
        public static BitBuffer Serialize(Gun t)
        {
            var b = Serialize((Holdable)t);
            //kickforce
            //bulcol
            b.Write(t.lowerOnFire);
            //botl
            //lotl
            //firesound
            //clicksound
            b.Write(t._fireWait);
            //nbpf
            //AT
            b.Write(t.loseAccuracy);
            b.Write(t.maxAccuracyLost);
            //bangleo
            return b;
        }
        public static BitBuffer Serialize(BaseGun t)
        {
            var b = Serialize((Gun)t);
            return b;
        }
        public static BitBuffer Serialize(TypedGun t)
        {
            var b = Serialize((BaseGun)t);
            return b;
        }
    }
}
#endif