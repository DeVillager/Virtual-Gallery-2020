using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float duration;

    private void Update()
    {
        transform.position = Vector3.Lerp(start.position, end.position, Mathf.PingPong(Time.time, duration) / duration);
    }
}
