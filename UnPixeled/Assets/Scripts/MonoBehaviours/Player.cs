using System;
using Services;
using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        [Inject] private InputService _inputService;


        private void Update()
        {
            transform.Translate(_inputService.MovementVector * Time.deltaTime);
        }
    }
}