using Services.Camera;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Camera
{
    public class CameraTarget : MonoBehaviour
    {
        [Inject] private CameraService _cameraService;
        
        
        private void Start()
        {
            _cameraService.SetTargetTransform(transform);
        }
    }
}