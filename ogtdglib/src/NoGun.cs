using DuckGame;
using JetBrains.Annotations;

namespace ogtdglib
{
    /// <summary>
    /// Gun-like object to sync-ly spawn bullets
    /// </summary>
    [PublicAPI]
    public sealed class NoGun : Gun
    {
        private readonly uint _ttd;
        private readonly float _x;
        private readonly float _y;
        private uint _t;

        /// <summary>
        /// Gun-like object with AT ammoType and time to decay ttd
        /// </summary>
        /// <param name="xval"></param>
        /// <param name="yval"></param>
        /// <param name="ammoType"></param>
        /// <param name="ttd"></param>
        public NoGun(float xval, float yval, AmmoType ammoType, uint ttd) : base(xval, yval)
        {
            enablePhysics = false;
            _ammoType = ammoType;
            ammo = 99;
            infiniteAmmoVal = true;
            canPickUp = false;
            _flareAlpha = 0;
            _clickSound = "";
            _fireSound = "";
            maxAccuracyLost = 0;
            loseAccuracy = 0;
            _kickForce = 0;
            _fireWait = 0;
            _x = xval;
            _y = yval;
            thickness = -1;
            _ttd = ttd;
        }

        /// <inheritdoc />
        public override void Update()
        {
            x = _x;
            y = _y;
            _t += 1;
            if (_t < _ttd) return;
            if (_destroyed) return;
            //else
            Destroy();
            Level.Remove(this);
            infiniteAmmoVal = false;
            ammo = 0;
            _ammoType = null;
        }

        /// <inheritdoc />
        protected override bool OnDestroy(DestroyType destroyType = null)
        {
            return true;
        }
    }
}