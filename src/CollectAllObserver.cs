using UnityEngine;

public class CollectAllObserver : MonoBehaviour
{
    public CollectAllNotifier notifier;
    public Transform player;
    bool looked = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notifier.OnLook += MoveToPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        if (looked)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, 5f * Time.deltaTime);
        }
    }
    
    void MoveToPlayer()
    {
        looked = true;
    }
}
