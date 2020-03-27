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
    
    void Start()
    {
        waterEffect.Stop();
        interactable = GetComponent<Interactable>();
        
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
