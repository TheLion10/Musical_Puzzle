using UnityEngine;

public class ButterflyEffect : MonoBehaviour
{
    public GameObject flower;
    private Vector3 direction;
    private Vector3 startingDirection;
    private Vector3 startingPos;
    private Vector3 flowerPos;
    private float force = 0.1f;
    private float landingEps = 20f;
    private float restartEps = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
        flowerPos = flower.transform.position;
        startingDirection = new Vector3(flowerPos.x - transform.position.x, 0, flowerPos.z - transform.position.z).normalized;
        direction = startingDirection;
        transform.forward = direction;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(new Vector2(transform.position.x, transform.position.z),
                new Vector2(flowerPos.x, flowerPos.z)) < landingEps)
        {
            direction = flowerPos - transform.position;
        }

        if (Vector3.Distance(transform.position, flowerPos) < restartEps)
        {
            transform.position = startingPos;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            direction = startingDirection;
        }
        GetComponent<Rigidbody>().AddForce(direction * force);
    }
}
