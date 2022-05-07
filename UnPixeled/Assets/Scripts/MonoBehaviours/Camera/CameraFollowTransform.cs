using Services;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Camera
{
    public class CameraFollowTransform : MonoBehaviour
    {
        [Inject] private ActorsService _actorsService;
        
        public float _smoothSpeed = 0.125f;
        public Vector3 _offset;
        

        private void LateUpdate()
        {
            if (!_actorsService.PlayerTransform) return;
            
            Vector3 desiredPosition = _actorsService.PlayerTransform.position + _offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}