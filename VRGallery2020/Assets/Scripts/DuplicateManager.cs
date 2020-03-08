using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class DuplicateManager : MonoBehaviour
{
    public SteamVR_Action_Boolean deleteAction;
    private Interactable interactable;

    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable.attachedToHand != null)
        {
            SteamVR_Input_Sources source = interactable.attachedToHand.handType;
            if (deleteAction[source].stateDown)
            {
                RemoveDuplicates();
            }
        }
    }

    void RemoveDuplicates()
    {
        Debug.Log("Duplicates destroyed");
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
