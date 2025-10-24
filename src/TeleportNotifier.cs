using System;
using UnityEngine;

public class TeleportNotifier : MonoBehaviour
{
    public delegate void teleport();
    public event teleport OnTrigger;
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
    if (other.gameObject.CompareTag("Player"))
    {
        OnTrigger();
    }
  }
}
