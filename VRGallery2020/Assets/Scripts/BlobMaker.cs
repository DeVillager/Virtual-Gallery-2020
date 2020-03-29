using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobMaker : MonoBehaviour
{
    public GameObject blob;
    public int blobAmount = 50;

    void Start()
    {
        for (int i = 0; i < blobAmount; i++)
        {
            Instantiate(blob, new Vector3(Random.Range(-2f,2f),1f, Random.Range(-2f,2f)), Quaternion.identity, transform);
        }
    }
}
