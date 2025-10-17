using UnityEngine;

public class AddForceBola : MonoBehaviour
{
    public float speed = 0.5f;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
    }
}
