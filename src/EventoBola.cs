using UnityEngine;

public class EventoBola : MonoBehaviour
{
    public delegate void colision();
    public event colision OnChoque;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("cilindro"))
    {
            OnChoque();
    }
  }
}
