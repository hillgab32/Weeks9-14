using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject spike;

    public Vector3 currentTransform;
    public float timer;
    public float spawnRate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTransform = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        

        if(timer > spawnRate)
        {
            float spikePosition = Random.Range(-8, 8);


            Instantiate(spike, new Vector3(spikePosition, currentTransform.y, currentTransform.z), Quaternion.identity);
            timer = 0f;
        }

        timer += Time.deltaTime;

        
    }
}
