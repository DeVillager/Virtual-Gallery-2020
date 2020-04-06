using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskGuy : MonoBehaviour
{
    [SerializeField]
    private float moveAmount = 0.05f;
    private GameObject player;

    //private void Start()
    //{
    //    player = GameObject.Find("MyPlayer");
    //}

    public void MoveTowardPlayer()
    {
        transform.parent.position += transform.forward * moveAmount;
    }
}
