using UnityEngine;
using System.Collections;
 
public class BigHands : MonoBehaviour
{
    public float speed;
    public float tolerance;
    public float startYPos;
    public float endYPos;
    private float target;
    private Vector3 position;

    // Update is called once per frame
    void Update()
    {
        // Get current position
        position = transform.position;
        float curYPos = position.y;

        // Move between the start and end vectors
        if (isApproximate(curYPos, endYPos, tolerance))
        {
            target = startYPos;
        }
        else if (isApproximate(curYPos, startYPos, tolerance))
        {
            target = endYPos;
        }

        // Update position
        transform.position = Vector3.Lerp(position, new Vector3(position.x, target, position.z), speed * Time.deltaTime);

    }

    bool isApproximate(float a, float b, float tolerance)
    {
        return Mathf.Abs(a - b) < tolerance;
    }
}
