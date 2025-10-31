using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    //public delegate void cambiaPuntuacion(int p);
    //public event cambiaPuntuacion OnCambio;
    int puntuacion = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            puntuacion += 1;
            Debug.Log(puntuacion);
            //OnCambio(puntuacion);
            other.gameObject.SetActive(false);
        }
    }
}
