using UnityEngine;
using Zenject;

namespace Services.Input
{
    public class InputServiceInstaller : MonoInstaller
    {
        [SerializeField] private InputService _inputService;

        
        public override void InstallBindings()
        {
            Container.Bind<InputService>()
                .FromComponentInNewPrefab(_inputService)
                .AsSingle();
        }
    }
}