using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    private float GRAVITY = -10;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 normal = transform.position.normalized;
        _rigidbody.AddForce(normal * GRAVITY);

        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, normal) * transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 50 * Time.deltaTime);
    }
}
