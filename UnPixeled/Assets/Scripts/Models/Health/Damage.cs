using UnityEngine;

namespace Models.Health
{
    [System.Serializable]
    public class Damage
    {
        [SerializeField] private float _damage;

        public float GetDamage() => _damage;
    }
}