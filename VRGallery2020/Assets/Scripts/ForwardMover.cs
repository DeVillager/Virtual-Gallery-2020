using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;


public class ForwardMover : MonoBehaviour
{
    [SerializeField]
    private int speed = 3;
    [SerializeField]
    private bool forwardReversed = true;
    private int direction;

    void Update()
    {
        direction = forwardReversed ? -1 : 1;
        transform.position += direction * transform.forward * Time.deltaTime * speed;
    }

}
