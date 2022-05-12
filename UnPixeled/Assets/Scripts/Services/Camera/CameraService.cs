using Components;
using UnityEngine;

namespace Services.Camera
{
    public class CameraService : MonoBehaviour
    {
        private CameraMovementComponent _cameraMovementComponent;


        public void InitializeCamera(CameraMovementComponent cameraMovementComponent)
        {
            _cameraMovementComponent = cameraMovementComponent;
        }
        
        public void SetTargetTransform(Transform targetTransform)
        {
            _cameraMovementComponent.SetTarget(targetTransform);
        }
    }
}