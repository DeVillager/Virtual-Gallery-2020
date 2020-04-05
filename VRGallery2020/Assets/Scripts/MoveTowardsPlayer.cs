using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "MaskGuy")
        {
            Debug.Log(other.gameObject.name);
            other.gameObject.GetComponent<MaskGuy>().MoveTowardPlayer();
        }
    }
}
