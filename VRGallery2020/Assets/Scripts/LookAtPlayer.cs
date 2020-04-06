using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject player;
    public bool forwardReversed = false;
    private Transform target;

    void Start()
    {
        player = PlayerSpawnController.instance.GetPlayer();
        target = player.GetComponentInChildren<Camera>().transform;
    }

    void Update()
    {
        transform.LookAt(target);
        float yRotation = forwardReversed ? 0 : 180;
        float xRotation = forwardReversed ? -transform.eulerAngles.x : 0;
        transform.Rotate(xRotation, yRotation, 0);

        //if (forwardReversed)
        //{
        //    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        //}
    }
}
