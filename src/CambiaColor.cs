using Unity.VisualScripting;
using UnityEngine;

public class CambiaColor : MonoBehaviour
{
    private Material material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

  // Update is called once per frame
  void OnCollisionEnter(Collision collision)
  {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colision detectada con: " + collision.gameObject.tag + " en el objeto " + gameObject.tag);
            material.color = new Color(Random.value, Random.value, Random.value);
        }
  }
}
