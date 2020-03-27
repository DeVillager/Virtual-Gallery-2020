using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;


public class ForwardMover : MonoBehaviour
{
    [SerializeField]
    private int speed = 3;
    [SerializeField]
    private float time = 0;
    [SerializeField]
    private int lifetime = 16;

    void Update()
    {
        time += Time.deltaTime;
        transform.position += transform.forward * Time.deltaTime * speed;
        if (time > lifetime)
        {
            Destroy(gameObject);
        }
    }
}
