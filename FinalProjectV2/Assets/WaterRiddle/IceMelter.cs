using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMelter : MonoBehaviour
{
    public GameObject water;
    public GameObject fire;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            water.gameObject.transform.position = gameObject.transform.position;
            fire.SetActive(false);
            water.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
