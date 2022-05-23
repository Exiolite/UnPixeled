using Models;
using UnityEngine;

namespace Components.Health
{
    [RequireComponent(typeof(Collider))]
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private HealthStats _healthStats;
        
        
        public void ApplyDamage(HealthDamage healthDamage)
        {
            _healthStats.ApplyDamage(healthDamage);
            
            if (_healthStats.IsHealthGreaterThanZero()) return;

            Destroy(gameObject);
        }
    }
}