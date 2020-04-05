using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;


public class ForwardMover : MonoBehaviour
{
    [SerializeField]
    private int speed = 3;

    void Update()
    {
        transform.position += -transform.forward * Time.deltaTime * speed;
    }
}
