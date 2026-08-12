using JetBrains.Annotations;
using UnityEngine;

public class HeartSpawner : MonoBehaviour
{
    public GameObject heart;

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
        
    }

    public void SpawnHeart()
    {
        float heartPosition = Random.Range(-3, 3);

        GameObject spawnHeart = Instantiate(heart);
        timer = 0f;

        spawnHeart.transform.position = new Vector3(currentTransform.x, heartPosition, currentTransform.z);

        Debug.Log("yo");

    }
}
