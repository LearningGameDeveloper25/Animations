using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        this._animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (this._animator != null)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                this._animator.SetTrigger("RunTrigger");
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                this._animator.SetTrigger("IdleTrigger");
            }
        }
    }
}
