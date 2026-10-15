using UnityEngine;

public class meshRenderer : MonoBehaviour
{
    void OnMouseDown()
    {
       gameObject.GetComponent<MeshRenderer>().material.color = Color.red; 
    }
}
