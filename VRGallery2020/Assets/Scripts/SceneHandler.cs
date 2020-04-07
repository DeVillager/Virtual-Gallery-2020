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
        if (e.target.tag == "Exit" || e.target.tag == "Loader")
        {
            Debug.Log("Exit was clicked");
            e.target.GetComponent<SteamVR_LoadLevel>().Trigger();
        }
        else if (e.target.tag == "Image")
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
        } else if (e.target.tag == "Quit")
        {
            Debug.Log("Quitting the game...");
            Application.Quit();
            //AudioSource quitSound = e.target.GetComponent<AudioSource>();
            //quitSound.PlayOneShot(quitSound.clip);
            //QuitGame();
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.tag == "Loader")
        {
            Debug.Log($"Show {e.target.name} info");
            e.target.GetComponent<ArtistImage>().ShowInfo();
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.tag == "Loader")
        {
            Debug.Log($"Hide {e.target.name} info");
            e.target.GetComponent<ArtistImage>().HideInfo();
        }
    }

    //IEnumerator QuitGame()
    //{
    //    yield return new WaitForSeconds(1f);
    //    Application.Quit();
    //}
}
