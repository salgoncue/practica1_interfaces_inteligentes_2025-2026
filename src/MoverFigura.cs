using UnityEngine;

public class MoverFigura : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.forward * Input.GetAxis("Horizontal") + Vector3.up * Input.GetAxis("Vertical")) * speed * Time.deltaTime);
    }
}
