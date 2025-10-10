using UnityEngine;

public class VelocidadCubo : MonoBehaviour
{
    public float velocity = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0) {
            if( Input.GetKey(KeyCode.LeftArrow)) {
                Debug.Log(KeyCode.LeftArrow + " ha sido pulsada: " + velocity * Input.GetAxis("Horizontal"));
            } else if (Input.GetKey(KeyCode.RightArrow)) {
                Debug.Log(KeyCode.RightArrow + " ha sido pulsada: " + velocity * Input.GetAxis("Horizontal"));
            }
        }
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0) {
            if (Input.GetKey(KeyCode.UpArrow)) {
                Debug.Log(KeyCode.UpArrow + " ha sido pulsada: " + velocity * Input.GetAxis("Vertical"));
            } else if (Input.GetKey(KeyCode.DownArrow)) {
                Debug.Log(KeyCode.DownArrow + " ha sido pulsada: " + velocity * Input.GetAxis("Vertical"));
            }
        }
    }
}
