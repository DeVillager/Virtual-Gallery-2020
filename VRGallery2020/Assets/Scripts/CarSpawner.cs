using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject carPrefab;
    private float time = 0;
    private float spawnTime = 3;
    public float spawnTimeMin = 2;
    public float spawnTimeMax = 12;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > spawnTime)
        {
            Instantiate(carPrefab, transform.position, transform.rotation);
            time = 0;
            spawnTime = Random.Range(spawnTimeMin, spawnTimeMax);
        }
    }
}
