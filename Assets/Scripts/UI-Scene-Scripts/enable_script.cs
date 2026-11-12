using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable_script : MonoBehaviour
{
    public GameObject objectToToggle; 
    
    public void Activate0bjectBotton()
    {
       objectToToggle.SetActive(true);
    }
}
