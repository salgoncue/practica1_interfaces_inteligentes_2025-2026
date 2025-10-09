using UnityEngine;

public class DistanciaEsfera : MonoBehaviour
{
    GameObject capsula;
    GameObject cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        capsula = GameObject.FindWithTag("Capsula");
        cubo = GameObject.FindWithTag("Cubo");
        Debug.Log("La distancia de la esfera con la capsula es: " + Vector3.Distance(transform.position, capsula.transform.position));
        Debug.Log("La distancia de la esfera con el cubo es: " + Vector3.Distance(transform.position, cubo.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
