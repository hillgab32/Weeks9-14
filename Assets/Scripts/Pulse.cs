using System.Diagnostics;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float pulseDuration;
    public float pulseProgress;
    private float pulseEndPoint = 9.6f;
    private float pulseStartPoint = -9.6f;
    public AnimationCurve pulseCurve;
    TrailRenderer trailRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(pulseProgress > 0)
        {
            trailRenderer.emitting = true;
        }

        Vector3 pulseMovement = transform.position;
        pulseMovement.x = Mathf.Lerp(pulseStartPoint, pulseEndPoint, pulseProgress / pulseDuration);
        pulseProgress += Time.deltaTime;

        pulseMovement.y = pulseCurve.Evaluate(pulseProgress / pulseDuration);

        Vector2 heartRateScreenPos = Camera.main.WorldToScreenPoint(pulseMovement);


        if (heartRateScreenPos.x >= Screen.width - 7)
        {
            trailRenderer.emitting = false;
            
        }
        if (heartRateScreenPos.x >= Screen.width){
            pulseProgress = 0;
        }



            transform.position = pulseMovement;

    }
}
