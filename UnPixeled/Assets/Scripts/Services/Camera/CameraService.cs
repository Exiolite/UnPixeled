using MonoBehaviours.Camera;
using UnityEngine;

namespace Services.Camera
{
    public class CameraService : MonoBehaviour
    {
        private CameraController _cameraController;


        public void InitializeCamera(CameraController cameraController)
        {
            _cameraController = cameraController;
        }
        
        public void SetTargetTransform(Transform targetTransform)
        {
            _cameraController.SetTarget(targetTransform);
        }
    }
}