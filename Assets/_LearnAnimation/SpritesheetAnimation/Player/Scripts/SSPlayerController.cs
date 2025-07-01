namespace Controller.Player
{
    using Controller.Animation;
    using UnityEngine;

    public class SSPlayerController : MonoBehaviour
    {
        private Vector2 Movement;

        [Header(" Animation ")]
        public SSAnimationController Anim;

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            if (Mathf.Abs(horizontal) > Mathf.Abs(vertical))
            {
                vertical = 0;
            }
            else
            {
                horizontal = 0;
            }

            Movement = new Vector2(horizontal, vertical).normalized;
            Anim.SetState(Movement);
        }
    }
}

