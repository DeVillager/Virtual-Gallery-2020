using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class WaterGun : MonoBehaviour
{
    public SteamVR_Action_Boolean fireAction;
    public ParticleSystem waterEffect;
    private Interactable interactable;
    private bool isShooting = false;
    private AudioSource audioSource;
    
    void Start()
    {
        waterEffect.Stop();
        interactable = GetComponent<Interactable>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (interactable.attachedToHand != null)
        {
            SteamVR_Input_Sources source = interactable.attachedToHand.handType;
            if (fireAction[source].stateDown)
            {
                //isShooting = true;
                waterEffect.Play();
                audioSource.PlayOneShot(audioSource.clip);
            }
            else if (fireAction[source].stateUp)
            {
                waterEffect.Stop();
                //isShooting = false;
            }
        } else
        {
            waterEffect.Stop();
        }
    }

}
