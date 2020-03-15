using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using DigitalRuby.SoundManagerNamespace;

public class DuplicateGallery : MonoBehaviour
{
    public GameObject duplicate;
    public float distance = 1f;

    private float phi = 1.618f;
    private Vector3 position;

    void Start()
    {
        MakeDuplicates();
    }

    void MakeDuplicates()
    {
        Create(0, 1, phi);
        Create(0, -1, phi);
        Create(0, 1, -phi);
        Create(0, -1, -phi);
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
        position = transform.position + new Vector3(x, y, z) * distance;
        GameObject created = Instantiate(duplicate, position, Quaternion.identity);
        created.transform.LookAt(gameObject.transform);
        created.transform.SetParent(gameObject.transform);
    }

}
