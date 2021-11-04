using UnityEngine;

namespace Asteroids
{
    internal sealed class DamageHandling : IDamage
    {
        public void ChangeDamage(float _hp, Player _player)
        {
            if (_hp <= 0)
            {
                _player.DestroyPlayer();
            }
            else
            {
                _hp--;
            }
        }
    }
}
