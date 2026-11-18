using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator animator;
    ///<summeray>
    /// start is called on the frame when script is enabled just before
    /// any of the update methods i called the first time
    /// <summary>
    void start;
    {
        animator=gameObject.GetComponent<Animator>();
    }
    ///<summary>
    /// OnMouseDown is called when the user has pressed the mouse botton
    /// while over the GUIElement or collider.
    /// <summary>

    // Update is called once per frame
    void OnMouseDown()
    {
        animator.setBool("DoorClicked", true);
    }
}
