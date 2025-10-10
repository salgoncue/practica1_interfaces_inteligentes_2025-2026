using UnityEngine;

public class VectoresEsferas : MonoBehaviour
{
    public Vector3 v1;
    public Vector3 v2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("La magnitud de v1 es: " + v1.magnitude);
        Debug.Log("La magnitud de v2 es: " + v2.magnitude);
        Debug.Log("El ángulo que forman v1 y v2 es: " + Vector3.Angle(v1, v2));
        Debug.Log("La distancia entre v1 y v2 es: " + Vector3.Distance(v1, v2));
        Debug.Log(v1.y > v2.y ? "v1 está por encima de v2" 
            : (v2.y > v1.y ? "v2 está por encima de v1" : "v1 y v2 están a la misma altura"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
