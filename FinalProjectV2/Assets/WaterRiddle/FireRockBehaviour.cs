using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRockBehaviour : MonoBehaviour
{
    public GameObject fire;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FireRock"))
        {
            fire.transform.position = transform.position;
                fire.SetActive(true);
            fire.transform.SetParent(null);
        }
    }
}
