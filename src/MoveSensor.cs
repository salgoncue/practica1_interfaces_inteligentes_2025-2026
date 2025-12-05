using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveSensor : MonoBehaviour
{
    Rigidbody rb;
    public TMP_Text text;
    Quaternion right = Quaternion.Euler(0,0,-90);
    Quaternion top = Quaternion.Euler(0,0,0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InputSystem.EnableDevice(Accelerometer.current);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 accel = Accelerometer.current.acceleration.ReadValue();
        text.text = $"Valor: {accel:F2}";
        rb.MovePosition(new Vector3(0,0,-accel.z) + transform.position);
        rb.MoveRotation(Quaternion.Slerp(right, top, -accel.y));
    }
}
