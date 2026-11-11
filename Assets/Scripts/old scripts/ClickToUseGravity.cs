using TMPro;
using UnityEngine;

public class ClickToChangeColour : MonoBehaviour
{
    /// <summary>
    /// OnMouseDown is called when user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
      gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
      
    
    
}
