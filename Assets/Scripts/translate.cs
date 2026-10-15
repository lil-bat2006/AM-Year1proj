using Unity.VisualScripting;
using UnityEngine;

public class translate : MonoBehaviour
{
    public float movementSpeed;
    public float roationSpeed;

        void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S))
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
        }*/
        //move forwards
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime);
        }
        //move backwards
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);
        }
        //roate right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(transform.up*roationSpeed*Time.deltaTime);
        }
        //roate left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(transform.up*roationSpeed*Time.deltaTime);
        }


    }
         
    
}
