using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealText : MonoBehaviour
{
    public Sprite[] sprites;
    private int index;
    private Image image;
    private AudioSource audioSource;

    void Start()
    {
        image = GetComponent<Image>();
        audioSource = GetComponent<AudioSource>();
        index = 0;
        RevealMore();
    }

    public void RevealMore()
    {
        Debug.Log("revealed more");
        audioSource.PlayOneShot(audioSource.clip);
        if (index < sprites.Length)
        {
            image.sprite = sprites[index];
            index++;
        }
    }
}
