using UnityEngine;
using UnityEngine.InputSystem;

public class Eyeball : MonoBehaviour
{
    public float eyeSpeed;
    private Vector2 movementDirection = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movementDirection * eyeSpeed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
        transform.up = movementDirection;
    }

    public void OnBoost()
    {
        eyeSpeed++;
    }

    
}
