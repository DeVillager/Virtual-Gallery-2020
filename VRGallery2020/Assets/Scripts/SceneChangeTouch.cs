using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SceneChangeTouch : MonoBehaviour
{
    public SteamVR_Action_Boolean loadAction;

    private SteamVR_LoadLevel loader;
    private Interactable interactable;
    private bool handHover = false;

    void Start()
    {
        loader = GetComponent<SteamVR_LoadLevel>();
        interactable = GetComponent<Interactable>();
    }

    public void OnHandHoverBegin()
    {
        handHover = true;
        //hand.ShowGrabHint();
    }
    public void OnHandHoverEnd()
    {
        handHover = false;
        //hand.ShowGrabHint();
    }

    void Update()
    {
        //if (interactable.attachedToHand != null)
        //{
        //SteamVR_Input_Sources source = ;
        if (loadAction.stateDown && handHover)
        {
            Debug.Log("Scene loaded");
            loader.Trigger();
        }
        //}
    }
}
