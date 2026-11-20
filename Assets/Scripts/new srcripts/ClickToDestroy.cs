using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
      Debug.Log("Object was clicked");
      Debug.Error("Object was clicked");
      Debug.Warning("Object was clicked");
      Destroy(ClickToDestroy);
    }
}
