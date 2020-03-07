/* SceneHandler.cs*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR;
using System.IO;


public class SceneHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    private GameObject activeImage;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Exit" || e.target.tag == "Loader")
        {
            Debug.Log("Exit was clicked");
            e.target.GetComponent<SteamVR_LoadLevel>().Trigger();
        }
        if (e.target.tag == "Image")
        {
            Debug.Log("rotated");
            //Quaternion endRotation = Quaternion.Euler(0, activeImage.transform.rotation.y + 90, 0);
            //activeImage.transform.rotation = Quaternion.Lerp(activeImage.transform.rotation, endRotation, Time.time * 1);
            if (activeImage != null)
            {
                activeImage.GetComponent<ImageRotater>().OnDeActivate();
            }
            activeImage = e.target.gameObject;
            activeImage.GetComponent<ImageRotater>().OnActivate();
            //e.target.GetComponent<SteamVR_LoadLevel>().Trigger();
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was entered");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was entered");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was exited");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was exited");
        }
    }
}
