using Services;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        
        [Header("Settings")]
        [SerializeField] private float _moveSpeed = 10;
        
        private Rigidbody _rigidBody;
        private Vector3 _movementVelocity;


        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _movementVelocity = new Vector3();
        }
        
        private void FixedUpdate()
        {
            _movementVelocity.x = _inputService.MovementVector.x * _moveSpeed;
            _movementVelocity.y = _rigidBody.velocity.y;
            _movementVelocity.z = _inputService.MovementVector.y * _moveSpeed;
            
            _rigidBody.velocity = _movementVelocity;
        }
    }
}