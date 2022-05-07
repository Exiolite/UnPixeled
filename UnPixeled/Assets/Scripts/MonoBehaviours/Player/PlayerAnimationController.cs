using System;
using Services.Input;
using UnityEngine;
using Zenject;

namespace MonoBehaviours.Player
{
    public class PlayerAnimationController : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        
        [SerializeField] private Animator _animator;

        private static readonly int Move = Animator.StringToHash("Move");
        private static readonly int StuffAttack = Animator.StringToHash("StuffAttack");
        private static readonly int Attack1 = Animator.StringToHash("Attack");
        

        public void Update()
        {
            MovementAnimations();
            UpdateWeaponAnimation();
        }
        
        
        private void MovementAnimations()
        {
            _animator.SetInteger(Move, _inputService.MovementVector != Vector2.zero ? 1 : 0);
        }
        
        private void UpdateWeaponAnimation()
        {
            //UpdateAttack();
            //UpdateDefence();
        }

        private void UpdateAttack()
        {
            if (false)
            {
                _animator.SetInteger(StuffAttack, 1);
            }
            else if (Input.GetAxis("Attack") == 0)
            {
                _animator.SetInteger(StuffAttack, 0);
                _animator.SetInteger(Attack1, 0);
            }
            else
            {
                _animator.SetInteger(StuffAttack, 0);
                _animator.SetInteger(Attack1, 0);
            }
        }

        private void UpdateDefence()
        {

        }
    }
}