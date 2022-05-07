using Services;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Player
{
    public class PlayerModelRotator : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        
        private Transform _transform;
        private Vector3 _rotationAngle;


        private void Awake()
        {
            _transform = GetComponent<Transform>();
            
            _rotationAngle = new Vector3();
        }
        
        
        private void LateUpdate()
        {
            if (_inputService.MovementVector == Vector2.zero) return;
            
            _rotationAngle.y = Mathf.Atan2(_inputService.MovementVector.x, _inputService.MovementVector.y) * Mathf.Rad2Deg;
            _transform.rotation = Quaternion.Euler(_rotationAngle);
        }
    }
}