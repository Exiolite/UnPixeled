using System;
using Models;
using UnityEngine;

namespace Components.Health
{
    [RequireComponent(typeof(HealthComponent))]
    public class ActorAttackComponent : MonoBehaviour
    {
        [SerializeField] private HealthDamage _healthDamage;

        private HealthComponent _healthComponent;

        private void Awake()
        {
            _healthComponent = GetComponent<HealthComponent>();
        }


        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out HealthComponent healthComponent))
            {
                if (_healthComponent == healthComponent) return;
                
                healthComponent.ApplyDamage(_healthDamage);
            }
        }
    }
}