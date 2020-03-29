using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobInitializer : MonoBehaviour
{
    public int planeSize = 30;
    public int minScale = 5;
    public int maxScale = 20;
    public float minHeight = 0.5f;
    public float maxHeight = 1.5f;
    public float minRotation = 0f;
    public float maxRotation = 360f;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(0.5f, 1.2f), Random.Range(-5f, 5f));
        //transform.position = new Vector3(Random.Range(-planeSize, planeSize), Random.Range(minHeight, maxHeight), Random.Range(-planeSize, planeSize));
        transform.rotation = Quaternion.Euler(Random.Range(minRotation, maxRotation), Random.Range(minRotation, maxRotation), Random.Range(minRotation, maxRotation));
        transform.localScale = Vector3.one * Random.Range(minScale, maxScale);
    }

}
