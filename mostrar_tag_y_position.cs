using UnityEngine;

public class mostrar_tag_y_position : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Tag del objeto: " + gameObject.tag + " y posición del objeto: " + gameObject.transform.position);
    }
}
