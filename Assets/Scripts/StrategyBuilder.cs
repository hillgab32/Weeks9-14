using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;

public class StrategyBuilder : MonoBehaviour
{
    public GameObject building;

    // private Coroutine brickBuildCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasReleasedThisFrame)
        {
            Instantiate(building);
        }
        // brickBuildCoroutine = StartCoroutine(BrickBuild());
    }

    /**private IEnumerator BrickBuild()
    {
        float t = 0;

        while (t < brickBuildDuration)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * t / brickBuildDuration;

            yield return null;
        }

        //WAIT AFTER THE TREE HAS GROWN FOR A SECOND BEFORE GROWING THE APPLES
        yield return new WaitForSeconds(1);
    } */
}
