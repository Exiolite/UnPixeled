using Services.Camera;
using UnityEngine;
using Zenject;

namespace Components
{
    public class CameraTargetComponent : MonoBehaviour
    {
        [Inject] private CameraService _cameraService;
        
        
        private void Start()
        {
            _cameraService.SetTargetTransform(transform);
        }
    }
}