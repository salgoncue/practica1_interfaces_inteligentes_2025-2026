using UnityEngine;

public class RotateObserver : MonoBehaviour
{
    public TeleportNotifier notifier;
    public Transform escudo;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        notifier.OnTrigger += Rotate;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Rotate()
    {
        rb.MoveRotation(Quaternion.Euler(0f, Vector3.Angle(transform.position, escudo.position)-90f, 0f));
    }
}
