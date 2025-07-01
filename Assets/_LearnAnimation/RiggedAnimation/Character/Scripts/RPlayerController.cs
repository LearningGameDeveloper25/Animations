namespace Controller.Player
{
    using Controller.Animation;
    using UnityEngine;

    public class RPlayerController : MonoBehaviour
    {
        public RAnimationController Animation;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Animation.SetIsFlying(1);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                Animation.SetIsFlying(2);
            }
            else
            {
                Animation.SetIsFlying(0);
            }
        }
    }
}
