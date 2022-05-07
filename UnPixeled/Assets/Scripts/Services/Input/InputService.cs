using UnityEngine;
using UnityEngine.InputSystem;

namespace Services.Input
{
    public class InputService : MonoBehaviour
    {
        public Vector2 MovementVector { get; private set; }
        public bool isLeftMouseButtonDown { get; private set; }

        public void EventToUpdateMovementVector(InputAction.CallbackContext callbackContext)
        {
            MovementVector = callbackContext.ReadValue<Vector2>().normalized;
        }
    }
}