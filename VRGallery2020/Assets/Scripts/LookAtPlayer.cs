using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject player;
    public bool forwardReversed = false;

    void Start()
    {
        player = PlayerSpawnController.instance.GetPlayer();
    }

    void Update()
    {
        transform.LookAt(player.transform);
        float yRotation = forwardReversed ? 0 : 180;
        float xRotation = forwardReversed ? 0 : 30;
        transform.Rotate(xRotation, yRotation, 0);
    }
}
