using UnityEngine;

namespace Asteroids
{
    internal class MoveTransform : IMove
    {
        private readonly Transform _transform;
        private Vector3 _move;
        private readonly Rigidbody _rigidbody;

        public float Speed { get; protected set; }

        public MoveTransform(Transform transform, float speed, Rigidbody rigidbody)
        {
            _transform = transform;
            Speed = speed;
            _rigidbody = rigidbody;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * Speed;
            _move.Set(horizontal * speed, vertical * speed, 0.0f);
            _rigidbody.AddForce(_move * speed);
        }
    }
}