using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTrigger : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }
    private void OnMouseEnter()
    {
        animator.enabled = true;
    }

    private void OnMouseExit()
    {
        animator.enabled = false;
    }
}
