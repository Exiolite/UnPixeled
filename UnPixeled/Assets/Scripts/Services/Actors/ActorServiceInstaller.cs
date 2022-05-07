using UnityEngine;
using Zenject;

namespace Services.Actors
{
    public class ActorServiceInstaller : MonoInstaller
    {
        [SerializeField] private ActorsService _actorsService;
        
        public override void InstallBindings()
        {
            Container.Bind<ActorsService>()
                .FromComponentInNewPrefab(_actorsService)
                .AsSingle();
        }
    }
}