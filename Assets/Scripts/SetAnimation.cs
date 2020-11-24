using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimation : MonoBehaviour
{
    public Animator animator;

    private ClickManager clicked;


    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        
    }

    private void OnMouseDown()
    {
        if (clicked)
        {
            
            animator.SetBool("hit", true);
            Debug.Log(name + " was clicked.");
        }
        //anim.SetTrigger("AnimHit");
        
    }

}
