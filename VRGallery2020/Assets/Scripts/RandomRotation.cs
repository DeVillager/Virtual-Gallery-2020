using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    void Start()
    {
        //int x, y, z;
        //x = Random.Range(0,180);
        gameObject.transform.Rotate(new Vector3(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180)), Space.Self);
       
    }

    
}
