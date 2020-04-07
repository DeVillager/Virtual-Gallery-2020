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
    public bool yRotationEnabled = false;

    void Update()
    {
        if (input.axis.magnitude > 0.1)
        {
            //TODO: lerp rotation        
            gameObject.transform.Rotate(new Vector3(yRotationEnabled ? input.axis.y : 0, input.axis.x, 0) * angles * Time.deltaTime, Space.World);
        }
    }
}
