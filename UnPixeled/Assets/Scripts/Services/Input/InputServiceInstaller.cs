using Services;
using UnityEngine;
using Zenject;

namespace MonoInstallers
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