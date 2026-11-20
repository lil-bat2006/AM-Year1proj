using UnityEngine;

public class EndGameBad : MonoBehaviour
{

    public GameObject endScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        endScreen.SetActive(true);
        Destroy(gameObject);

    }
}
