using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskGuy : MonoBehaviour
{
    [SerializeField]
    private float moveAmount = 0.1f;

    public void MoveTowardPlayer()
    {
        transform.parent.position += transform.forward * moveAmount;
    }
}
