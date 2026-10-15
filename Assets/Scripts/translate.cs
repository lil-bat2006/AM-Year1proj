using UnityEngine;

public class translate : MonoBehaviour
{
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0,0,10);
            Debug.Log("S Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0,0,-10);
            Debug.Log("W Key Was Pressed");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1,0,0);
            Debug.Log("D Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1,0,-0);
            Debug.Log("A Key Was Pressed");
        }
    }
         
    
}
