using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float xBound = 0.0f;
    public float yBoundUp = 0.0f;
    public float yBoundDown = 0.0f;
    public GameObject spawnPrefab;
    private Vector2 spawnPos;
    // For prefab spawner
    public float startDelay = 2.0f;
    public float spawnRate = 2.0f;
    void Start()
    {
        InvokeRepeating("SpawnPrefab", startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPrefab(){
        spawnPos = new Vector2(xBound, Random.Range(yBoundUp, yBoundDown));
        Instantiate(spawnPrefab, spawnPos, spawnPrefab.transform.rotation);
    }
}
