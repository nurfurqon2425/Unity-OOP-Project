using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] targetPrefabs;

    private float upperBound = 8.0f;
    private float lowerBound = -6.0f;
    private float rightBound = 25.0f;
    private float leftBound = -20.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine(0));
        StartCoroutine(SpawnCoroutine(1));
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCoroutine()
    {
        while(true)
        {
            GameObject obj = SpawnTarget(2);
            yield return new WaitForSeconds(5.0f);
            Destroy(obj);
        }
    }

    //POLYMORPHISM
    IEnumerator SpawnCoroutine(int index)
    {
        while (true)
        {
            GameObject obj = SpawnTarget(index);
            float seconds = Random.Range(1.0f, 3.0f);
            yield return new WaitForSeconds(seconds);
            Destroy(obj);
        }
    }

    private GameObject SpawnTarget(int targetIndex)
    {
        float xPoint = Random.Range(leftBound, rightBound);
        float yPoint = Random.Range(lowerBound, upperBound);
        Vector3 spawnPosition = new Vector3(xPoint, yPoint, -1);
        return Instantiate(targetPrefabs[targetIndex], spawnPosition, transform.rotation);
    }
}
