using UnityEngine;

public class UHH : MonoBehaviour
{   
    public float maxspeed = 10f;
    public float minspeed = 1f;
    float srandom  = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        srandom = Random.Range(minspeed, maxspeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down* Time.deltaTime * srandom);
    }
}
