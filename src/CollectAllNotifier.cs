using Unity.VisualScripting;
using UnityEngine;

public class CollectAllNotifier : MonoBehaviour
{
    public delegate void notifier();
    public event notifier OnLook;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnPointerEnter()
    {
        OnLook();
    }
    
    void OnPointerExit()
    {
    
    }
}
