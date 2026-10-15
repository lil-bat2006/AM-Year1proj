using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            Debug.Log("the user just pressed the aA key");
           }
        if (Input.GetKeyDown(KeyCode.A)){
            Debug.Log("the user is pressing the A key");
        }
        if (Input.GetKeyDown(KeyCode.A)){
            Debug.Log("the user has released the A key");
        }
    }
}
