namespace Controller.Animation
{
    using UnityEngine;

    public class RAnimationController : MonoBehaviour
    {
        private Animator _animator;
        private bool _isFlying = false;

        private void Awake()
        {
            this._animator = GetComponent<Animator>();
            this._animator.enabled = false;
        }

        private void Update()
        {
            if (this._isFlying)
            {
                this._animator.enabled = true;
                this._animator.Play("Fly");

            }
            else
            {
                this._animator.enabled = false;
            }
        }

        public void SetIsFlying(int isFlying)
        {
            if (isFlying == 0) return;

            if (isFlying == 1)
            {
                this._isFlying = true;
            }
            else if (isFlying == 2)
            {
                this._isFlying = false;
            }
        }
    }
}
