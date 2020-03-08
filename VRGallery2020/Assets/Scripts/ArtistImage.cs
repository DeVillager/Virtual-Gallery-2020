using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtistImage : MonoBehaviour
{
    [SerializeField]
    private GameObject artistInfo;

    void Start()
    {
        HideInfo();
    }

    public void ShowInfo()
    {
        artistInfo.SetActive(true);
    }
    public void HideInfo()
    {
        artistInfo.SetActive(false);
    }
}
