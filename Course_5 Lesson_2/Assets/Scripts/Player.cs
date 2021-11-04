using UnityEngine;

namespace Asteroids
{
    internal class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;

        private Rigidbody _rigidbody;
        private Camera _camera;
        private Ship _ship;
        private DamageHandling _damageHandling;
        private PlayerFire _playerFire;
        private PlayerController _playerController;

        private void Start()
        {
            _camera = Camera.main;

            _rigidbody = GetComponent<Rigidbody>();

            var moveTransform = new AccelerationMove(transform, _speed, _acceleration, _rigidbody);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);

            _playerController = new PlayerController( _camera.transform , _camera, _ship, _playerFire);

            _playerFire = new PlayerFire(_barrel,  _force, _bullet);
        }

        private void Update()
        {
            _playerController.ControllerPlayer();

            /*var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);

            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);
            

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }
            


            if (Input.GetButtonDown("Fire1"))
            {
                var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
                temAmmunition.AddForce(_barrel.up * _force);
            }*/

        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _damageHandling.ChangeDamage(_hp, this);
        }

        public void DestroyPlayer()
        {
            Destroy(gameObject);
        }
    }
}