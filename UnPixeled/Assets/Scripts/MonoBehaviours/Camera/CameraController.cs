using Services.Camera;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private float _smoothSpeed = 0.125f;
        [SerializeField] private Vector3 _offset;

        [Inject] private CameraService _cameraService;

        private Transform _targetTransform;


        private void Awake()
        {
            _cameraService.InitializeCamera(this);
        }

        private void LateUpdate()
        {
            if (!_targetTransform) return;

            Vector3 desiredPosition = _targetTransform.position + _offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
        
        
        public void SetTarget(Transform targetTransform)
        {
            _targetTransform = targetTransform;
        }
    }
}