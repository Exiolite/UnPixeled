using Services;
using UnityEngine;

namespace MonoInstaller
{
    public class ServicesInstaller : Zenject.MonoInstaller
    {
        [SerializeField] private InputService inputService;
    
        public override void InstallBindings()
        {
            Container.Bind<InputService>().FromComponentInNewPrefab(inputService).AsSingle();
        }
    }
}