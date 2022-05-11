using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Services.Input
{
    public class InputService : MonoBehaviour
    {
        public Vector3 MovementVector { get; private set; }
        public bool IsMovementVectorZero { get; private set; } 
        
        public bool IsLeftMouseButtonDown { get; private set; }
        public bool IsRightMouseButtonDown { get; private set; }
        
        private static readonly Vector3 IsometricMovementRotation = new Vector3(0, 45, 0);
        private Transform _transform;


        private void Awake()
        {
            _transform = GetComponent<Transform>();
            
            _transform.eulerAngles = IsometricMovementRotation;
        }


        public void EventToUpdateMovementVector(InputAction.CallbackContext callbackContext)
        {
            Vector2 callbackValue = callbackContext
                .ReadValue<Vector2>()
                .normalized;
            
            MovementVector = callbackValue.x * _transform.right + callbackValue.y * _transform.forward;
            
            IsMovementVectorZero = MovementVector == Vector3.zero;
        }
        
        public void EventToUpdateLeftMouseButton(InputAction.CallbackContext callbackContext)
        {
             IsLeftMouseButtonDown = callbackContext.ReadValueAsButton();
        }
        
        public void EventToUpdateRightMouseButton(InputAction.CallbackContext callbackContext)
        {
            IsRightMouseButtonDown = callbackContext.ReadValueAsButton();
        }
    }
}