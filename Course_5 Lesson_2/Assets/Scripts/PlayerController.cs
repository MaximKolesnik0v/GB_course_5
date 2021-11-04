using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerController
    {
        private Transform transform;
        private Camera camera;
        private Ship ship;
        private PlayerFire playerFire;

        public PlayerController(Transform _transform, Camera _camera, Ship _ship, PlayerFire _playerFire)
        {
            this.playerFire = _playerFire;
            this.transform = _transform;
            this.camera = _camera;
            this.ship = _ship;
        }

        public void ControllerPlayer()
        {
            var direction = Input.mousePosition - camera.WorldToScreenPoint(transform.position);
            ship.Rotation(direction);

            ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                ship.RemoveAcceleration();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                 playerFire.Fire();
            }
        }
    }
}
