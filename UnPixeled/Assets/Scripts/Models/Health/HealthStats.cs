using UnityEngine;

namespace Models.Health
{
    [System.Serializable]
    public class HealthStats
    {
        [SerializeField] private float _health = 100f;
        
        public void ApplyDamage(Damage damage) => _health -= damage.GetDamage();
        public bool IsHealthGreaterThanZero() => _health > 0;
    }
}