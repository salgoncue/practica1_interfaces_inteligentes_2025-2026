using UnityEngine;

public class MoverCubo : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * speed);
    }
}
