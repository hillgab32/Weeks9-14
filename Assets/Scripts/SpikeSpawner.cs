using UnityEngine;
using UnityEngine.Events;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject spike;

    public Vector3 currentTransform;
    public float timer;
    public float spawnRate;

    public UnityEvent spawnSpike;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTransform = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSpike()
    {
        float spikePosition = Random.Range(-3, 3);

        GameObject spawnSpike = Instantiate(spike);
        timer = 0f;

        spawnSpike.transform.position = new Vector3(spikePosition, currentTransform.y, currentTransform.z);

        Debug.Log("yo");

    }
}
