using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject candy;

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
       /**  if (timer > spawnRate)
        {
            float heartPosition = Random.Range(-3, 3);

            GameObject spawnHeart = Instantiate(candy);
            timer = 0f;

            spawnHeart.transform.position = new Vector3(currentTransform.x, heartPosition, currentTransform.z);

        }

        timer += Time.deltaTime; */
    }

    public void SpawnCandy()
    {
        float heartPosition = Random.Range(-3, 3);

        GameObject spawnCandy = Instantiate(candy);
        timer = 0f;

        spawnCandy.transform.position = new Vector3(currentTransform.x, heartPosition, currentTransform.z);

        Debug.Log("yo");

    }
}