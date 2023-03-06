using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootBehaviour : MonoBehaviour
{
    public GameObject staticRoot;
    // void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log("AAA!");
    //     if (collision.gameObject.CompareTag("Player"))
    //     {
    //         Debug.Log("Yay!");
    //         GetComponent<Animator>().enabled = false;
    //     }
    // }

    public void Stop()
    {
        // GetComponent<"XRGrabInteractable">().enabled = false;
        gameObject.SetActive(false);
        staticRoot.SetActive(true);
    }
}
