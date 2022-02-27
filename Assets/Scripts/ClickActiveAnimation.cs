using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickActiveAnimation : MonoBehaviour
{
    private Animator animator;
    private bool isActive = true;

    private void Awake()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.SetBool("Click", isActive);
        isActive = !isActive;
    }
}
