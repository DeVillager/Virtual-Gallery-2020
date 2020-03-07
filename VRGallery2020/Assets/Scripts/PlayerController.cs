using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1f;
    public float gravity = 9.81f;
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (input.axis.magnitude > 0.1)
        {
            Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
            //Vector3.Lerp(transform.position, Vector3.ProjectOnPlane(direction, Vector3.up), Time.deltaTime);
            //characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up));
            characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0, gravity, 0) * Time.deltaTime);
        }
    }
}
