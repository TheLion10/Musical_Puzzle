using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SeedGenerator : MonoBehaviour
{
    public GameObject Bag;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Bag.transform.up.y);
        //if(Bag.transform.rotation.x >= 90 || Bag.transform.rotation.z >= 90 || Bag.transform.rotation.x <= -90 || Bag.transform.rotation.z <= -90)
        // if (Bag.rotation.x >= 170 && transform.rotation.x <= 190)
        if(Bag.transform.up.y < 0)
        {
            Debug.Log("enable gravity now");
            transform.SetParent(null);
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
