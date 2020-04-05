using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;
using System;

public class GhostGirl : MonoBehaviour
{
    //public ParticleSystem vanish;
    public GameObject vanish;
    //public AudioSource audioSource;
    public Material material;
    private Color a;
    private Color b;
    public float lifeTime = 10f;
    private float time;
    private bool transparentToOpacity = true;

    private void Start()
    {
        time = 0;
        a = Color.white;
        b = Color.white;
        b.a = 0f;
    }

    private void Update()
    {
        time += Time.deltaTime;
        //if (time < lifeTime / 2)
        //{
        transform.GetComponent<Renderer>().material.color = Color.Lerp(b, a, Mathf.PingPong(2 * time, lifeTime) / lifeTime);
        //}
        //else
        //{
        //    transform.GetComponent<Renderer>().material.color = Color.Lerp(a, b, time / lifeTime);
        //}

        if (time > lifeTime)
        {
            Destroy(this.gameObject);
        }
    }

    public void Disappear()
    {
        Instantiate(vanish, transform.position, Quaternion.identity);
        AudioManager.instance.Play();
        Destroy(this.gameObject);
    }
}
