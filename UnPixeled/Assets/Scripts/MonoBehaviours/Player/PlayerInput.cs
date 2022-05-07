using Services;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerInput : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        [Inject] private ActorsService _actorsService;
        
        [SerializeField] private Transform _modelTransform;
        
        private Rigidbody _rigidBody;


        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _actorsService.SetPlayerTransform(transform);
        }


        private void FixedUpdate()
        {
            _rigidBody.velocity = new Vector3(_inputService.MovementVector.x * 10, _rigidBody.velocity.y, _inputService.MovementVector.y * 10);
            
            float angle = Mathf.Atan2(_inputService.MovementVector.x, _inputService.MovementVector.y) * Mathf.Rad2Deg;
            _modelTransform.transform.rotation = Quaternion.Euler(new Vector3(0, angle + 45, 0));
        }
    }
}