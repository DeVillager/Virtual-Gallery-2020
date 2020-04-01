using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ConnectObject : MonoBehaviour
{
    public List<GameObject> connectedObjects;
    public Dictionary<GameObject, Vector3> objectPositions;
    public Dictionary<GameObject, Quaternion> objectRotations;
    public float radius = 1f;
    public LayerMask layerMask;

    void Start()
    {
        objectPositions = new Dictionary<GameObject, Vector3>();
        objectRotations = new Dictionary<GameObject, Quaternion>();
        AddNeighbors();
        foreach (GameObject obj in connectedObjects)
        {
            //Transform savedTransform = Instantiate(obj.transform, obj.transform.position, obj.transform.rotation);
            objectPositions[obj] = obj.transform.position;
            objectRotations[obj] = obj.transform.rotation;
        }
    }

    private void AddNeighbors()
    {
        Collider[] neighbors = Physics.OverlapSphere(transform.position, radius, layerMask);
        foreach (Collider item in neighbors)
        {
            connectedObjects.Add(item.gameObject);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    GameObject collidedObject = other.gameObject;
    //    if (collidedObject.layer == LayerMask.NameToLayer("Face"))
    //    {
    //        Debug.Log($"{other.gameObject.name} entered");
    //        if (objectTransforms.ContainsKey(collidedObject))
    //        {
    //            collidedObject.GetComponent<Interactable>().attachedToHand.AttachObject(this.gameObject, GrabTypes.Scripted, Hand.AttachmentFlags.DetachOthers, null);
    //            Transform t = objectTransforms[collidedObject];
    //            collidedObject.transform.position = t.position;
    //            collidedObject.transform.rotation = t.rotation;
    //        }
    //    }
    //}
}
