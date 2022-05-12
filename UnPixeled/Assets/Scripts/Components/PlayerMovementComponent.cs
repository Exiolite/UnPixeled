using Services.Input;
using UnityEngine;
using Zenject;

namespace Components
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovementComponent : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        
        [Header("Settings")]
        [SerializeField] private float _maxSpeed = 10;
        [SerializeField] private float _velocity = 60;
        private float _currentSpeed = 0;
        
        private CharacterController _characterController;
        
        
        
        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }
        
        private void LateUpdate()
        {
            _characterController.Move((transform.forward * CalculateSpeed() + Physics.gravity) * Time.deltaTime);
        }

        private float CalculateSpeed()
        {
            return _inputService.IsMovementVector ?
                _currentSpeed = Mathf.Clamp(_currentSpeed + _velocity * Time.deltaTime, 0, _maxSpeed) 
                : 
                _currentSpeed = Mathf.Clamp(_currentSpeed - _velocity * Time.deltaTime, 0, _maxSpeed) ;
        }
    }
}