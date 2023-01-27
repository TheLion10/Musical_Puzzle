using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using Random = UnityEngine.Random;

public class SeedGenerator : MonoBehaviour
{
    public GameObject Bag;
    public GameObject grass;
    private bool hitHill = false;

    // Update is called once per frame
    void Update()
    {
        if (!hitHill && Bag.transform.up.y < 0)
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
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

    void CreateGrass()
    {
        grass.SetActive(true);
    }
}
