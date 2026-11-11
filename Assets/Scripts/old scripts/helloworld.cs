using UnityEngine;
//this script is for a debug log statement

public class helloworld : MonoBehaviour

{   
    
 
    void OnEnable()
    {
     Debug.Log("helloworld");
    }

    void OnDisable()
    {
     Debug.Log("goodbeyworld");
    }
}


