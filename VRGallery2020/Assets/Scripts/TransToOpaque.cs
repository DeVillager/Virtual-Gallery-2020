using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TransToOpaque : MonoBehaviour
{
    private float time;
    public float timeToVisible = 5f;
    private Color a;
    private Color b;

    private void Start()
    {
        time = 0;
        a = Color.white;
        a.a = 0f;
        b = Color.white;
    }

    void Update()
    {
        time += Time.deltaTime;
        transform.GetComponent<TextMeshProUGUI>().color = Color.Lerp(a, b, time / timeToVisible);
    }
}
