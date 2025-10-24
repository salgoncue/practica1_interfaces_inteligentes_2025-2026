using UnityEngine;

public class TeleportObserver : MonoBehaviour
{
    public TeleportNotifier notifier;
    public Transform escudo;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        notifier.OnTrigger += Teleport;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Teleport()
  {
        rb.Move(escudo.position, transform.rotation);
  }
}
