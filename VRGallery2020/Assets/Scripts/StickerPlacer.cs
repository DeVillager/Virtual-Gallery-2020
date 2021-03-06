﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;



public class StickerPlacer : MonoBehaviour
{
    public GameObject Player;
    public GameObject starSticker;
    public GameObject heartSticker;
    public LayerMask layerMask;
    public float distance = 0.5f;
    public float hitDistanceUp = 0.00001f;
    public float hitDistanceUpAmount = 0.00001f;
    public RaycastHit hit;
    private bool wasHit;
    private GameObject newSticker;

    public SteamVR_Action_Boolean stickerAction;
    public SteamVR_Input_Sources inputSource;
    
    void Update()
    {
        wasHit = Physics.Raycast(transform.position, transform.forward, out hit, distance, layerMask);
        if (stickerAction[inputSource].stateDown)
        {
            PlaceSticker();
        }
    }


    public void PlaceSticker()
    {
        if (wasHit)
        {
            hitDistanceUp += hitDistanceUpAmount;
            if (inputSource == SteamVR_Input_Sources.RightHand)
            {
                newSticker = Instantiate(starSticker, hit.point + hit.normal * hitDistanceUp, transform.rotation);
            }
            else
            {
                newSticker = Instantiate(heartSticker, hit.point + hit.normal * hitDistanceUp, transform.rotation);
            }
            newSticker.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);
            newSticker.transform.Rotate(new Vector3(90 + UnityEngine.Random.Range(0, 360f), 90, 0));
            
            //newSticker.transform.Rotate(new Vector3(transform.rotation.z, 0, 0));
            newSticker.transform.parent = hit.transform;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = wasHit ? Color.red : Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * distance);
    }

}
