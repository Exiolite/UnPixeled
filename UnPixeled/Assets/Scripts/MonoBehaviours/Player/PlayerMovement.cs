using Services.Input;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        
        [Header("Settings")]
        [SerializeField] private float _moveSpeed = 10;
        
        private CharacterController _characterController;
        
        private Vector3 _movementVelocity;


        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            
            _movementVelocity = new Vector3();
        }
        
        private void Update()
        {
            _movementVelocity.x = _inputService.MovementVector.x * _moveSpeed;
            _movementVelocity.y = Physics.gravity.y;
            _movementVelocity.z = _inputService.MovementVector.y * _moveSpeed;

            _characterController.Move(_movementVelocity * Time.deltaTime);
        }
    }
}