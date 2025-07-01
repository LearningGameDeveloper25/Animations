namespace Controller.Player 
{
    using UnityEngine;
    using UnityEngine.U2D.Animation;

    public class SwitchController : MonoBehaviour
    {
        private SpriteResolver _spriteResolver;

        private void Awake()
        {
            this._spriteResolver = GetComponent<SpriteResolver>();
            this._spriteResolver.SetCategoryAndLabel("Head", "BlinkHead");
        }

    }
}
