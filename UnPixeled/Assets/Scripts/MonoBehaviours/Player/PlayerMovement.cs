using Services;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("GameObjects")]
        [SerializeField] private Transform _modelTransform;
        
        [Header("Settings")]
        [SerializeField] private float _moveSpeed;
        
        [Inject] private InputService _inputService;
        [Inject] private ActorsService _actorsService;
        
        private Rigidbody _rigidBody;
        private Vector3 _movementVelocity;
        private Vector3 _rotationAngle;


        private void Awake()
        {
            _actorsService.SetPlayerTransform(transform);
            
            _rigidBody = GetComponent<Rigidbody>();
            _rotationAngle = new Vector3();
            _movementVelocity = new Vector3();
        }
        
        private void FixedUpdate()
        {
            FixedUpdateMovementVelocity();
        }

        private void LateUpdate()
        {
            LateUpdateRotationAngle();
        }

        
        private void FixedUpdateMovementVelocity()
        {
            _movementVelocity.x = _inputService.MovementVector.x * _moveSpeed;
            _movementVelocity.y = _rigidBody.velocity.y;
            _movementVelocity.z = _inputService.MovementVector.y * _moveSpeed;
            
            _rigidBody.velocity = _movementVelocity;
        }

        private void LateUpdateRotationAngle()
        {
            if (_inputService.MovementVector == Vector2.zero) return;
            
            _rotationAngle.y = Mathf.Atan2(_inputService.MovementVector.x, _inputService.MovementVector.y) * Mathf.Rad2Deg;
            _modelTransform.rotation = Quaternion.Euler(_rotationAngle);
        }
    }
}