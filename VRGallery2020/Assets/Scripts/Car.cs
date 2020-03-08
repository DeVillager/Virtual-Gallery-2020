using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;


public class Car : MonoBehaviour
{
    public int speed = 3;
    private float time = 0;
    public int lifetime = 16;
    public AudioSource carNoise;


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
