namespace Controller.Animation
{
    using UnityEngine;

    public class SSAnimationController : MonoBehaviour
    {
        private Animator _animator;
        private int _state = 0;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (_state == 1)
            {
                _animator.Play("WalkRight");
            }
            else if (_state == 2)
            {
                _animator.Play("WalkLeft");
            }
            else if (_state == 3)
            {
                _animator.Play("WalkUp");
            }
            else
            {
                _animator.Play("Walk");
            }
        }

        public void SetState(Vector2 movement)
        {
            if (movement == Vector2.zero)
            {
                return;
            }
            if (movement == Vector2.right)
            {
                _state = 1;
            }  
            else if (movement == Vector2.left)
            {
                _state = 2;
            }
            else if (movement == Vector2.up)
            {
                _state = 3;
            }
            else
            {
                _state = 0;
            }
        }
    }
}