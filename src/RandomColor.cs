using UnityEngine;

public class RandomColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRandomColor() {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
