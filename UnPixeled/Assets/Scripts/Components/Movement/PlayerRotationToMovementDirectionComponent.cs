using Services.Input;
using UnityEngine;
using Zenject;

namespace Components.Movement
{
    public class PlayerRotationToMovementDirectionComponent : MonoBehaviour
    {
        [Inject] private InputService _inputService;

        [SerializeField] private float _rotationSpeed = 10;
        
        private Transform _transform;


        private void Awake()
        {
            _transform = GetComponent<Transform>();
        }
        
        private void LateUpdate()
        {
            if (!_inputService.IsMovementVector) return;
            
            Vector3 directionToTarget = _inputService.MovementVector - _inputService.transform.position;
            float angleToTarget = Mathf.Atan2(directionToTarget.x, directionToTarget.z) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0, angleToTarget, 0);
            _transform.rotation = Quaternion.Lerp(_transform.rotation, targetRotation, Time.deltaTime * _rotationSpeed);
        }
    }
}