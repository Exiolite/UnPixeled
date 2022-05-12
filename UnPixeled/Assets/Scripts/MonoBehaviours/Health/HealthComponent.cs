using Models.Health;
using UnityEngine;

namespace MonoBehaviours.Health
{
    [RequireComponent(typeof(Collider))]
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private HealthStats _healthStats;
        
        
        public void ApplyDamage(Damage damage)
        {
            _healthStats.ApplyDamage(damage);
            
            if (_healthStats.IsHealthGreaterThanZero()) return;

            Destroy(gameObject);
        }
    }
}