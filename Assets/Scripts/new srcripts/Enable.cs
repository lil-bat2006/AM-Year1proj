using UnityEngine;

public class ScriptExample : MonoBehaviour
{
   public class EnableObject : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        // Enable the object
        // // Log activeSelf (local activation) and activeInHierarchy (effective activation)
        Debug.Log($"Target '{target.name}' - activeSelf: {target.activeSelf}, activeInHierarchy: {target.activeInHierarchy}");
    }
    void TargetEnable()
    {
        target.SetActive(true);
    }
}
}