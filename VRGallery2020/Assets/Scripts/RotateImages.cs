using System;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class RotateImages : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float angles = 10;
    public SteamVR_Action_Vector2 input;
    public SteamVR_Input_Sources handType;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(input.axis.x);
        if (input.axis.magnitude > 0.1)
        {
            //TODO: lerp rotation
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(Vector3.up * angles), rotationSpeed * Time.deltaTime);
            gameObject.transform.Rotate(new Vector3(0, input.axis.x, 0) * angles * Time.deltaTime, Space.World);
        }
    }
}
