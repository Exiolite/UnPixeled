using Services.Input;
using UnityEngine;
using Zenject;

namespace Components.Animation
{
    public class PlayerAnimationsComponent : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        
        [SerializeField] private Animator _animator;

        private static readonly int Run = Animator.StringToHash("Run");
        private static readonly int StuffRunAttack = Animator.StringToHash("StuffRunAttack");
        private static readonly int StuffRunDefence = Animator.StringToHash("StuffRunDefence");
        private static readonly int StuffSteadyAttack = Animator.StringToHash("StuffSteadyAttack");
        private static readonly int StuffSteadyDefence = Animator.StringToHash("StuffSteadyDefence");
        

        private void Update()
        {
            _animator.SetInteger(Run, _inputService.IsMovementVector ? 1 : 0);
            _animator.SetInteger(StuffRunAttack, _inputService.IsLeftMouseButtonDown && _inputService.IsMovementVector ? 1 : 0);
            _animator.SetInteger(StuffRunDefence, _inputService.IsRightMouseButtonDown && _inputService.IsMovementVector ? 1 : 0);  
            _animator.SetInteger(StuffSteadyAttack, _inputService.IsLeftMouseButtonDown && !_inputService.IsMovementVector ? 1 : 0);
            _animator.SetInteger(StuffSteadyDefence, _inputService.IsRightMouseButtonDown && !_inputService.IsMovementVector ? 1 : 0);
        }
    }
}