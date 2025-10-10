using UnityEngine;

public class MirarEsfera : MonoBehaviour
{
    GameObject esfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        esfera = GameObject.FindWithTag("Esfera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(esfera.transform);
    }
}
