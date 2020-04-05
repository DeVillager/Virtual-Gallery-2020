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

    private void Start()
    {
        //vanish = GetComponent<ParticleSystem>();
    }

    public void Disappear()
    {
        Instantiate(vanish, transform.position, Quaternion.identity);
        AudioManager.instance.Play();
        Destroy(this.gameObject);
    }
}
