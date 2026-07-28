using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float pulseDuration;
    public float pulseProgress;
    private float pulseEndPoint = 9.6f;
    private float pulseStartPoint = -9.6f;
    public AnimationCurve pulseCurve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pulseMovement = transform.position;
        pulseMovement.x = Mathf.Lerp(pulseStartPoint, pulseEndPoint, pulseProgress / pulseDuration);
        pulseProgress += Time.deltaTime;

        transform.position = pulseMovement;
        pulseMovement.y = pulseCurve.Evaluate(pulseProgress / pulseDuration);
        transform.position = pulseMovement;
        if (pulseProgress > pulseDuration)
        {
            pulseProgress = 0;
        }
    }
}
