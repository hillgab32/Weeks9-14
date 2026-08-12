using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EyeDodger : MonoBehaviour
{
    public GameObject eyeball;
    public Slider healthBar;
    public Canvas parentCanvas;
    public UnityEvent healthZero;
    Slider healthBarSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(eyeball);
        //healthBarSlider = Instantiate(healthBar);
        //healthBarSlider.transform.SetParent(parentCanvas.transform, false);
        //slider.value = 100;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBar.value == 0)
        {
            healthZero.Invoke();
        }
    }
    public void OnDamage()
    {
        healthBarSlider.value -= 10;


        Debug.Log("Ouch");
    }

    public void OnHeal()
    {
        if (healthBar.value < 100)
        {
            healthBar.value += 10;
        }

    }
}
