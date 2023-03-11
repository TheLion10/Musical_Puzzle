using UnityEngine;

public class SeedGenerator : MonoBehaviour
{
    public GameObject Bag;
    public GameObject grass;
    private bool hitHill;
    private bool isFalling;

    // Update is called once per frame
    void Update()
    {
        if (!hitHill && Bag.transform.up.y < 0 && !isFalling)
        {
            float waitTime = Random.Range(0, 1f);
            Invoke("Generate", waitTime);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (hitHill)
        {
            return;
        }

        isFalling = false;
        if (collision.gameObject.CompareTag("Hill"))
        {
            hitHill = true;
            transform.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            transform.SetParent(null);
            gameObject.SetActive(false);
            Invoke("CreateGrass", 2);
        }
        
        else
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            transform.position = Bag.transform.position + Bag.transform.up * 0.55f;
        }
    }

    void Generate()
    {
        isFalling = true;
        transform.position = Bag.transform.position + Bag.transform.up * 0.55f;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

    void CreateGrass()
    {
        grass.transform.SetParent(null);
        grass.SetActive(true);
    }
}
