using UnityEngine;
public class ClickToDestroy : MonoBehaviour
{
    //public Enable enable;
    int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 4)
        {
            //enable.TargetEnable();
        }
       
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        count++;
    }

}
