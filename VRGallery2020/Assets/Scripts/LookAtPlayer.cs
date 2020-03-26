using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = PlayerSpawnController.instance.GetPlayer();
    }

    void Update()
    {
        transform.LookAt(player.transform);
        transform.Rotate(30, 180, 0);
    }
}
