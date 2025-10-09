using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public int frames = 120;
    private int elapsedFrames;
    private Material material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        elapsedFrames = 0;
        material = GetComponent<Renderer>().material;
        material.color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedFrames < frames) {
            ++elapsedFrames;
        }
        else {
            elapsedFrames = 0;
            material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
