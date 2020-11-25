using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimation : MonoBehaviour
{
    public Animator animatorX;
    public Animator animatorO;

    private ClickManager clicked;


    void Start()
    {
        animatorX = gameObject.GetComponent<Animator>();
        animatorO = gameObject.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (clicked)
        {
            
            animatorX.SetBool("hit", true);
            Debug.Log(name + " was clicked.");
        }
        //anim.SetTrigger("AnimHit");
        
    }

}
