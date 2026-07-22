using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;

public class StrategyBuilder : MonoBehaviour
{
    public List<Transform> brickTransforms;
    public GameObject building;
    public float brickBuildDuration;
    private Coroutine brickBuildCoroutine;
    public AnimationCurve constructionCurve;
    private float constructionProgress = 0f;
    private Coroutine brickCoroutine;
    

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
            brickBuildCoroutine = StartCoroutine(BuildingBuild());
        }

    }

    private IEnumerator BuildingBuild()
    {
        for (int i = 0; i < brickTransforms.Count; i++)
        {
            
            yield return brickCoroutine = StartCoroutine(BrickBuild(brickTransforms[i]));
        }

        yield return null;

        yield return new WaitForSeconds(0.5f);
    }
    
    private IEnumerator BrickBuild(Transform brickTransform)
    {

        float t = 0;
        while (t < brickBuildDuration)
        {
            t += Time.deltaTime;
            Vector3 growBuilding = brickTransform.localScale;
            
            growBuilding.y = constructionCurve.Evaluate( 1 * t / brickBuildDuration);

            brickTransform.localScale = growBuilding;

            yield return null;
        }


        yield return new WaitForSeconds(0.5f);
    }
}
