using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTrigger : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        animator.enabled = !animator.enabled;
    }
}
