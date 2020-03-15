using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryRotater : MonoBehaviour
{
    public GameObject[] planes;
    public float radius = 4;
    // Start is called before the first frame update
    void Awake()
    {
        //var newObject : GameObject[] = new GameObject[0];
        int numberOfObjects = planes.Length;
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            Debug.Log(angle*Mathf.Rad2Deg);
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;

            Instantiate(planes[i], pos, Quaternion.Euler(0, -angle * Mathf.Rad2Deg, 0), this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}
