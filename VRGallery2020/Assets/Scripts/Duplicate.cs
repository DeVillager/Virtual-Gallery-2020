using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using DigitalRuby.SoundManagerNamespace;

public class Duplicate : MonoBehaviour
{
    public GameObject duplicate;
    public SteamVR_Action_Boolean duplicateAction;
    private Interactable interactable;
    public float distance = 1f;
    public Transform parent;
    public AudioSource blob;
    public bool original = false;

    private float phi = 1.618f;
    private Vector3 position;

    void Start()
    {
        interactable = GetComponent<Interactable>();
        if (gameObject.tag == "Gallery")
        {
            MakeDuplicates();
        }
    }

    void Update()
    {
        if (interactable.attachedToHand != null)
        {
            SteamVR_Input_Sources source = interactable.attachedToHand.handType;
            if (duplicateAction[source].stateDown)
            {
                blob.PlayOneShot(blob.clip);
                MakeDuplicates();
            }
        }
        if (!original && transform.parent != parent)
        {
            transform.SetParent(parent);
        }
    }

    void MakeDuplicates()
    {
        Create(0, 1, phi);
        Create(0, -1, phi);
        Create(0, 1, -phi);
        Create(0, - 1, -phi);
        Create(1, phi, 0);
        Create(-1, phi, 0);
        Create(1, -phi, 0);
        Create(-1, -phi, 0);
        Create(phi, 0, 1);
        Create(phi, 0, -1);
        Create(-phi, 0, 1);
        Create(-phi, 0, -1);
        Debug.Log("Duplicates created");
    }

    void Create(float x, float y, float z)
    {
        //position = transform.position + Vector3.up * distance;
        position = transform.position + new Vector3(x, y, z) * distance;
        GameObject created = Instantiate(duplicate, position, Quaternion.identity);
        transform.LookAt(this.gameObject.transform);
        Vector3 scale = created.transform.localScale;
        created.transform.SetParent(parent);
        created.GetComponent<Rigidbody>().isKinematic = false;
        created.transform.localScale = scale;
        created.GetComponent<Duplicate>().original = false;
    }

}
