using UnityEngine;

public class CuboDamage : MonoBehaviour
{
    private Material material;
    public int damage = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.color = Color.red;
    }

  void OnTriggerEnter(Collider other)
  {
      if (other.CompareTag("Player"))
      {
            ++damage;
      }
  }
}
