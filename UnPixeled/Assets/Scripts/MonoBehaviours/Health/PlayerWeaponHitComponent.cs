using System;
using Models.Health;
using Services.Input;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Health
{
    [RequireComponent(typeof(Collider))]
    public class PlayerWeaponHitComponent : MonoBehaviour
    {
        [Inject] private readonly InputService _inputService;
        
        [SerializeField] private Damage _damage;

        private void OnTriggerEnter(Collider other)
        {
            if (!_inputService.IsLeftMouseButtonDown) return;
            if (other.CompareTag("Player")) return;
            if (other.gameObject.TryGetComponent(out HealthComponent healthComponent))
            {
                healthComponent.ApplyDamage(_damage);
            }
        }
    }
}