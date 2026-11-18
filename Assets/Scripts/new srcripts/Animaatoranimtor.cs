using UnityEngine;

public class Animaatoranimtor : MonoBehaviour
{
   Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = cabainet1 doors.GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        animator.SetBool("AnimationActivate", true);
    }
}
