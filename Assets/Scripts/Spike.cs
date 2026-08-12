using UnityEngine;
using UnityEngine.Events;

public class Spike : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Eyeball playerEyeball;

    public float spikeSpeed;
    bool isTouchingSpike = false;

    public UnityEvent onSpikeHit;
    //public UnityEvent offSpikeHit;

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

        if (playerRenderer.bounds.Contains(transform.position) && !isTouchingSpike)
        {
            Debug.Log("Ive been hit!");
            onSpikeHit.Invoke();
            isTouchingSpike = true;
        }
        if (!playerRenderer.bounds.Contains(transform.position) && isTouchingSpike)
        {
            //offSpikeHit.Invoke();
            isTouchingSpike = false;
        }

    }
}
