using UnityEngine;

public class CuboColor : MonoBehaviour
{
    private Material material;
    private Color originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.color = Color.green;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            originalColor = other.GetComponent<Renderer>().material.color;
            other.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Renderer>().material.color = originalColor;
        }
    }
}
