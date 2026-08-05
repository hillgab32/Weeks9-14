using UnityEngine;
using UnityEngine.Events;

public class Spike : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Eyeball playerEyeball;

    public float spikeSpeed;

    public UnityEvent onSpikeHit;
    public UnityEvent offSpikeHit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 spikeFall = transform.position;

        spikeFall.y -= spikeSpeed * Time.deltaTime;

        transform.position = spikeFall;

        Destroy(gameObject, 4f);
    }
}
