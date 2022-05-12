using UnityEngine;

namespace Models
{
    [System.Serializable]
    public class HealthStats
    {
        [SerializeField] private float _health = 100f;
        
        public void ApplyDamage(HealthDamage healthDamage) => _health -= healthDamage.GetDamage();
        public bool IsHealthGreaterThanZero() => _health > 0;
    }
}