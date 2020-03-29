using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 0.125f), 0.75f, 0.75f);
    }
}
