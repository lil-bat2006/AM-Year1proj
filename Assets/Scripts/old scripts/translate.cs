using Unity.VisualScripting;
using UnityEngine;

public class translate : MonoBehaviour
{
    public float movementSpeed;
    
        void Update()
    {
        //move forwards
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate (0,0,-10);
            Debug.Log("W key Pressed");
        }
        
        //move backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate (0,0,10);
            Debug.Log("S key Pressed");
        }
    
       /*
       {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime);
        }
       
       {
            transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);
        }
        
        */
        


    }
         
    
}
