using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillDigger : MonoBehaviour
{
    public GameObject player;
    public GameObject hill;
    private int canDig = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (canDig == 1 && collision.gameObject.CompareTag("Ground"))
        {
            hill.transform.position = transform.position;
            hill.transform.eulerAngles = player.transform.eulerAngles - Vector3.right * 90;
            hill.SetActive(true);
            canDig = 2;
        }
    }

    public void EnableDigging()
    {
        if (canDig == 0)
        {
            canDig = 1;
        }
    }
}
