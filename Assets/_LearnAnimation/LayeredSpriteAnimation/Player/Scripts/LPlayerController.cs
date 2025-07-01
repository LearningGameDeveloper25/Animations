namespace Controller.Player
{
    using Controller.Animation;
    using UnityEngine;

    public class LPlayerController : MonoBehaviour
    {
        public LAnimationController Animation;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Animation.SetState(1);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                Animation.SetState(2);
            }
            else
            {
                Animation.SetState(0);
            }
        }
    }
}