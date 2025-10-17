using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rb.AddForce(direccion * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
