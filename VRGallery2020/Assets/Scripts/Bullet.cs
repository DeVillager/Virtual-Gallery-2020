using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1;
    // Use this for initialization
    private Vector3 velocity;
    private Rigidbody rb;
    public LayerMask collisionMask;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        SetSpeed(1f);
    }

    public void SetSpeed(float shootingSpeed)
    {
        //speed = shootingSpeed;
        velocity = transform.forward * speed;
    }

    void FixedUpdate()
    {
        //transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    //void Update()
    //{
    //    Ray ray = new Ray(transform.position, transform.forward);
    //    RaycastHit hit;

    //    if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + .1f, collisionMask))
    //    {
    //        Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
    //        float rot = 90 - Mathf.Atan2(reflectDir.z, reflectDir.x) * Mathf.Rad2Deg;
    //        //float rot2 = 90 - Mathf.Atan2(reflectDir.y, reflectDir.x) * Mathf.Rad2Deg;
    //        //float rot3 = 90 - Mathf.Atan2(reflectDir.z, reflectDir.y) * Mathf.Rad2Deg;
    //        transform.eulerAngles = new Vector3(rot, rot, rot);
    //        Debug.Log(transform.eulerAngles);
    //    }
    //    //Debug.Log(velocity);
    //}
}
