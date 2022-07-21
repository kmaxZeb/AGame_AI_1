using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircle : MonoBehaviour
{
    public GameObject circlePrefab;
    public GameObject circlePrefabR;
    public GameObject circlePrefabB;
    public Vector3 spawnLocation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If Q pressed spawn circle
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(circlePrefab);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(circlePrefabR);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(circlePrefabB);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            float randomX = Random.Range(-0.5f, 0.5f);
            spawnLocation.x = spawnLocation.x + randomX;

            Instantiate(circlePrefab, spawnLocation, Quaternion.identity);
        }

    }
}
