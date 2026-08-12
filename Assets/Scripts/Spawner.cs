using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    //public GameObject heart;
    //public GameObject spike;
    //public GameObject candy;

    public Vector3 currentTransform;
    public float timer;
    public float spawnRate;

    public CandySpawner CandySpawner;
    public HeartSpawner HeartSpawner;
    public SpikeSpawner SpikeSpawner;

    public UnityEvent spawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTransform = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnRate)
        {
            spawn.Invoke();
            timer = 0f;
        }
    }


    public void Spawn()
    {
        CandySpawner.SpawnCandy();
        HeartSpawner.SpawnHeart();
        SpikeSpawner.SpawnSpike();

    }
}
