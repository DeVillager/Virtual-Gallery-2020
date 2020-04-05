using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnPrefab;

    [SerializeField]
    private int areasize = 5;

    [SerializeField]
    private float spawnTime = 5f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            Vector3 randomPosition = new Vector3(transform.position.x + Random.Range(-areasize, areasize), transform.position.y, transform.position.z  + Random.Range(-areasize, areasize));
            Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(spawnPrefab, randomPosition, randomRotation);
            yield return new WaitForSeconds(spawnTime);
        }   
    }
}
