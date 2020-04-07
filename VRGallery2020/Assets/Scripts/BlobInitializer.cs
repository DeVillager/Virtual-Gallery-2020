using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobInitializer : MonoBehaviour
{
    public float planeSize = 5;
    public int minScale = 5;
    public int maxScale = 20;
    public float minHeight = 0.5f;
    public float maxHeight = 1.2f;
    public float minRotation = 0f;
    public float maxRotation = 360f;
    public int blobAmount = 30;
    public GameObject blob;
    public Transform parent;

    void Start()
    {
        MakeSceneBlobs();
    }

    public void MakeSceneBlobs()
    {
        for (int i = 0; i < blobAmount; i++)
        {
            GameObject created = Instantiate(blob);

            created.transform.position = new Vector3(Random.Range(-planeSize, planeSize), Random.Range(minHeight, maxHeight), Random.Range(-planeSize, planeSize));
            created.transform.rotation = Quaternion.Euler(Random.Range(minRotation, maxRotation), Random.Range(minRotation, maxRotation), Random.Range(minRotation, maxRotation));
            created.transform.localScale = Vector3.one * Random.Range(minScale, maxScale);
            created.transform.SetParent(parent);
            created.GetComponent<Duplicate>().original = false;
        }
    }

}
