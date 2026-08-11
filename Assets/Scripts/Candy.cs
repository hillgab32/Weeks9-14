using UnityEngine;
using UnityEngine.Events;

public class Candy : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Eyeball playerEyeball;

    public float candySpeed;

    public UnityEvent onHeartHit;
    public UnityEvent offHeartHit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 candyMove = transform.position;

        candyMove.x -= candySpeed * Time.deltaTime;

        transform.position = candyMove;

        Destroy(gameObject, 20f);
    }
}
