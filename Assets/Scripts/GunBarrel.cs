using UnityEngine;
using UnityEngine.InputSystem;

public class GunBarrel : MonoBehaviour
{
    public Transform target;
    public Vector2 lookDirection = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 directionToTarget = target.position - transform.position;
        transform.up = lookDirection;
    }

    public void OnLook(InputAction.CallbackContext context)
    {

        lookDirection = context.ReadValue<Vector2>();

    }
}
