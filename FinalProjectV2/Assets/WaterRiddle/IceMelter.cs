using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMelter : MonoBehaviour
{
    public GameObject water;
    public GameObject fire;
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OOO!");
        if (collision.gameObject.CompareTag("Fire"))
        {
            Debug.Log("ICE!");
            water.gameObject.transform.position = gameObject.transform.position;
            fire.SetActive(false);
            water.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
