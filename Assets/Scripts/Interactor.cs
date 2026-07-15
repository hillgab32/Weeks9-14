using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    public List<SpriteRenderer> spriteChanger;

    public GameObject player;

    int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void ChangeSprite(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            Debug.Log(index);
            player.GetComponent<SpriteRenderer>().sprite = spriteChanger[index].sprite;
            index++;
            if (index >= spriteChanger.Count)
            {
                index = 0;
            }
        }
    }
}
