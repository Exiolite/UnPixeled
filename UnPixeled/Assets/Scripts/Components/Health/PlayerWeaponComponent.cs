using Models;
using Services.Input;
using UnityEngine;
using Zenject;

namespace Components.Health
{
    [RequireComponent(typeof(Collider))]
    public class PlayerWeaponComponent : MonoBehaviour
    {
        [Inject] private readonly InputService _inputService;
        
        [SerializeField] private HealthDamage _healthDamage;

        private void OnTriggerEnter(Collider other)
        {
            if (!_inputService.IsLeftMouseButtonDown) return;
            if (other.CompareTag("Player")) return;
            if (other.gameObject.TryGetComponent(out HealthComponent healthComponent))
            {
                healthComponent.ApplyDamage(_healthDamage);
            }
        }
    }
}