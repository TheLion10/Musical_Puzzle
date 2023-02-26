using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class FootstepsGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in transform)
        {
            Thread.Sleep(1000);
            child.gameObject.SetActive(true);
        }
    }
}
