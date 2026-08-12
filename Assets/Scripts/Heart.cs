using UnityEngine;
using UnityEngine.Events;

public class Heart : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Eyeball playerEyeball;

    public float heartSpeed;

    public UnityEvent onHeartHit;
    //public UnityEvent offHeartHit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 heartMove = transform.position;

        heartMove.x += heartSpeed * Time.deltaTime;

        transform.position = heartMove;

        Destroy(gameObject, 15f);

        if (playerRenderer.bounds.Contains(transform.position))
        {
            onHeartHit.Invoke();
            Destroy(gameObject);
        }
    }
}
