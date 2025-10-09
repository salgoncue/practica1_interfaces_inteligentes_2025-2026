using UnityEngine;

public class MarcadorDesplazamiento : MonoBehaviour
{
    public Vector3 desplazamiento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0f) {
            Debug.Log("La posición del marcador " + tag + " tras saltar es: " + (transform.position + desplazamiento));
        }
    }
}
