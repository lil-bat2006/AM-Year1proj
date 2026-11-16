using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void QuitGame0bject()
    {
        Application. Quit();
        Debug.Log("Application has Quit");
    }
}
