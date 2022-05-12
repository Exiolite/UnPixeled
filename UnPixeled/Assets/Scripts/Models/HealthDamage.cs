using UnityEngine;

namespace Models
{
    [System.Serializable]
    public class HealthDamage
    {
        [SerializeField] private float _damage;

        public float GetDamage() => _damage;
    }
}