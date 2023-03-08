using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeBehaviour : MonoBehaviour
{
    public GameObject iceBlock;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ice"))
        {
            iceBlock.SetActive(true);
            iceBlock.transform.SetParent(null);
            iceBlock.GetComponent<Rigidbody>().AddForce(-0.5f * transform.forward);
            gameObject.SetActive(false);
        }
    }
}
