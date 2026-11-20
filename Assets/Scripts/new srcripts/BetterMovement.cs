using UnityEngine;

public class BetterMovement : MonoBehaviour
{
    public float mySpeed = 10;// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BetterMovementMethod();
    }

    void BetterMovementMethod()//this script moves GameObjects in RealTime
    {
           if(Input.GetKey(KeyCode.S))
        {
            transform.Translate((-1)*transform.right*mySpeed*Time.deltaTime, Space.World);//old way of moving - moves 1 unit per frame  
            Debug.Log("S is pressed and the position is " + transform.position);
        }
        
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.right*mySpeed*Time.deltaTime, Space.World);//old way of moving - moves 1 unit per frame  
            Debug.Log("W is pressed and the position is " + transform.position);
        }
    }   
}