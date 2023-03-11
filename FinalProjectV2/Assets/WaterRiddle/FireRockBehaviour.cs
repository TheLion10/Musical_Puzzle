using UnityEngine;

public class FireRockBehaviour : MonoBehaviour
{
    public GameObject fire;
    private bool litFire;
    void OnCollisionEnter(Collision collision)
    {
        if (!litFire && collision.gameObject.CompareTag("FireRock"))
        {
            fire.transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
            fire.transform.up = Vector3.up;
                fire.SetActive(true);
            fire.transform.SetParent(null);
            litFire = true;
        }
    }
}
