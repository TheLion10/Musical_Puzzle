using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyDestroyer : MonoBehaviour
{
    public GameObject butterflyArmy;

    public void DestroyArmy()
    {
        butterflyArmy.SetActive(false);
    }
}
