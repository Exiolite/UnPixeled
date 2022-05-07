using Services.Input;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Player
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        
        [Header("Settings")]
        [SerializeField] private float _moveSpeed = 10;
        
        private CharacterController _characterController;
        private Rigidbody _rigidbody;
        
        private Vector3 _movementVelocity;


        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            _rigidbody = GetComponent<Rigidbody>();
            
            _movementVelocity = new Vector3();
        }
        
        private void Update()
        {
            _movementVelocity.x = _inputService.MovementVector.x * _moveSpeed;
            _movementVelocity.y = _rigidbody.velocity.y;
            _movementVelocity.z = _inputService.MovementVector.y * _moveSpeed;

            _characterController.Move(_movementVelocity * Time.deltaTime);
        }
    }
}