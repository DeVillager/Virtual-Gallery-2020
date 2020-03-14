using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class WaterGun : MonoBehaviour
{
    public SteamVR_Action_Boolean fireAction;
    public GameObject waterEffect;
    private Interactable interactable;
    
    void Start()
    {
        waterEffect.SetActive(false);
        interactable = GetComponent<Interactable>();
    }

    void Update()
    {
        if (interactable.attachedToHand != null)
        {
            SteamVR_Input_Sources source = interactable.attachedToHand.handType;
            if (fireAction[source].stateDown)
            {
                waterEffect.SetActive(true);
            }
            else if (fireAction[source].stateUp)
            {
                waterEffect.SetActive(false);
            }
        } else
        {
            waterEffect.SetActive(false);
        }
    }

}
