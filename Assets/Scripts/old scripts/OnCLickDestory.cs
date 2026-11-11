using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCLickDestory : MonoBehaviour
{
    /// <summary>
    /// OnMouseDown is called when user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>

    // Update is called once per frame
    void OnMouseDown()
    {
      GameObject.Destroy(transform.gameObject); 
    }
}
