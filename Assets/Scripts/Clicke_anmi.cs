using UnityEngine;

public class Clicke_anmi : MonoBehaviour
{
      Animator animator;
    
   
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
/// <summary>
/// OnMouseDown is called when the user has pressed the mouse button while 
/// over the GUIElment or Collider.
/// </summary>
    void OnMouseDown()
    {
        animator.SetBool("IsClicked", true);
    }
}
