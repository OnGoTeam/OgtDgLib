using DuckGame;
using OgtDgLib.AmmoTypes;

namespace OgtDgLib.Ext
{
    // ReSharper disable once InconsistentNaming
    public class SyncedAT:BaseAmmoType
    {
        public override void WriteAdditionalData(BitBuffer b)
        {
            base.WriteAdditionalData(b);
            WriteFull(b, this);
        }

        public override void ReadAdditionalData(BitBuffer b)
        {
            base.ReadAdditionalData(b);
            ReadFull(b, this);
        }
    }
}