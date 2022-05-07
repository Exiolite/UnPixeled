using UnityEngine;
using Zenject;

namespace Services.Camera
{
    public class CameraServiceInstaller : MonoInstaller
    {
        [SerializeField] private CameraService _cameraService;
        
        
        public override void InstallBindings()
        {
            Container.Bind<CameraService>()
                .FromComponentInNewPrefab(_cameraService)
                .AsSingle();
        }
    }
}