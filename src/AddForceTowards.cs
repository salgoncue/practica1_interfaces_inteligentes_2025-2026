using UnityEngine;

public class AddForceTowards : MonoBehaviour
{
    Rigidbody rb;
    public Transform t;
    public EventoBola e;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        e.OnChoque += AddForce;
    }
    
    void AddForce()
    {
        rb.AddForce((t.position - transform.position).normalized * 10, ForceMode.Impulse);
    }
}
