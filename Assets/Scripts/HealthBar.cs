using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    //private int healthBarValue;
    private int healthBarValueMax = 100;
    public UnityEvent healthZero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(healthBar.value == 0)
        //{
        //    healthZero.Invoke();
        //}
    }

    public void OnDamage()
    {
        //healthBar.value -= 10;


        //Debug.Log("Ouch");
    }

    public void OnHeal()
    {
        if(healthBar.value < 100)
        {
            healthBar.value += 10;
        }
        
    }
}
