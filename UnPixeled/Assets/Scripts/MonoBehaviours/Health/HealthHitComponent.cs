using Models.Health;
using UnityEngine;

namespace MonoBehaviours.Health
{
    [RequireComponent(typeof(Collider))]
    public class HealthHitComponent : MonoBehaviour
    {
        [SerializeField] private Damage _damage;
        
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out HealthComponent healthComponent))
            {
                healthComponent.ApplyDamage(_damage);
            }
        }
    }
}