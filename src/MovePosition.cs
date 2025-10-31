using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Vector3 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.parent.position + (speed * Time.fixedDeltaTime * movement));
    }
}
