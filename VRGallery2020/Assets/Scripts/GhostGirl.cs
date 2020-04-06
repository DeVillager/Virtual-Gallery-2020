using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;
using System;

public class GhostGirl : MonoBehaviour
{
    public GameObject vanish;
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
        transform.GetComponent<Renderer>().material.color = Color.Lerp(b, a, Mathf.PingPong(2 * time, lifeTime) / lifeTime);
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
