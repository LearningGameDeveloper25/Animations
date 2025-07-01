namespace Controller.Animation
{
    using UnityEngine;

    public class LAnimationController : MonoBehaviour
    {
        private Animator _animator;
        private int _state = 0;

        private void Awake()
        {
            this._animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (_state == 1)
            {
                this._animator.Play("Run");
            }
            else
            {
                this._animator.Play("Idle");
            }
        }

        public void SetState(int state)
        {
            if (state == 0) return;

            this._state = state;
        }
    }
}
