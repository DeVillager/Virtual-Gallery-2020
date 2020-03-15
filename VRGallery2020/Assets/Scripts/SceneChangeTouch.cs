using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SceneChangeTouch : MonoBehaviour
{
    public SteamVR_Action_Boolean loadAction;
    public GameObject[] destroyables;

    private SteamVR_LoadLevel sceneLoader;
    private Interactable interactable;
    private bool handHover = false;

    void Start()
    {
        sceneLoader = GetComponent<SteamVR_LoadLevel>();
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
        if (loadAction.stateDown && handHover)
        {
            Debug.Log("Scene loaded");
            if (destroyables.Length > 0)
            {
                foreach (var item in destroyables)
                {
                    Destroy(item);
                }
            }
            sceneLoader.Trigger();
        }
    }
}
