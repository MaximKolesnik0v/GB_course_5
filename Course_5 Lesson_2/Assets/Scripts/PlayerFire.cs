using UnityEngine;

namespace Asteroids
{
     internal class PlayerFire : MonoBehaviour
    {
        private Transform barrel;
        private float force;
        private Rigidbody2D bullet;

        public PlayerFire(Transform _barrel, float _force, Rigidbody2D _bullet)
        {
            this.barrel = _barrel;
            this.force = _force;
            this.bullet = _bullet;
        }

        public void Fire()
        {
            Rigidbody2D _temAmmunition = Instantiate(bullet, barrel.position, barrel.rotation);
            _temAmmunition.AddForce(barrel.up * force);
        }
    }
}

