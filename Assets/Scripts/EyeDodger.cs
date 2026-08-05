using UnityEngine;

public class EyeDodger : MonoBehaviour
{
    public GameObject eyeball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(eyeball);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnDeath()
    {
        Destroy(eyeball);
    }
}
