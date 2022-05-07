using UnityEngine;

namespace Services
{
    public class ActorsService : MonoBehaviour
    {
        public Transform PlayerTransform { get; private set; }


        public void SetPlayerTransform(Transform transform)
        {
            PlayerTransform = transform;
        }
    }
}