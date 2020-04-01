using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Teddy : MonoBehaviour
{
    public AudioSource kalinka;
    public AudioSource teddyPick;
    public AudioSource teddyDrop;

    private void OnAttachedToHand(Hand hand)
    {
        teddyPick.PlayOneShot(teddyPick.clip);
        kalinka.volume = 1f;
    }

    private void OnDetachedFromHand(Hand hand)
    {
        teddyDrop.PlayOneShot(teddyDrop.clip);
        kalinka.volume = 0.5f;
    }
}
