using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyEffect : MonoBehaviour
{
    public GameObject flower;
    private Vector3 direction;
    private Vector3 startingDirection;
    private Vector3 startingPos;
    private float force = 0.1f;
    private float landingEps = 20f;
    private float restartEps = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
        startingDirection = new Vector3(flower.transform.position.x - transform.position.x, 0, flower.transform.position.z - transform.position.z).normalized;
        direction = startingDirection;
        transform.forward = direction;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(new Vector2(transform.position.x, transform.position.z),
                new Vector2(flower.transform.position.x, flower.transform.position.z)) < landingEps)
        {
            direction = flower.transform.position - transform.position;
        }

        if (Vector3.Distance(transform.position, flower.transform.position) < restartEps)
        {
            transform.position = startingPos;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            direction = startingDirection;
        }
        GetComponent<Rigidbody>().AddForce(direction * force);
    }
}
