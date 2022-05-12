using Models;
using UnityEngine;

namespace Components
{
    [RequireComponent(typeof(Collider))]
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private HealthStats _healthStats;
        
        
        public void ApplyDamage(HealthDamage healthDamage)
        {
            _healthStats.ApplyDamage(healthDamage);
            Debug.Log("Hit");
            
            if (_healthStats.IsHealthGreaterThanZero()) return;

            Destroy(gameObject);
        }
    }
}