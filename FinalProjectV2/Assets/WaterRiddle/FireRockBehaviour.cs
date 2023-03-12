using UnityEngine;

public class FireRockBehaviour : MonoBehaviour
{
    public GameObject player;
    public GameObject fire;
    private bool litFire;
    void OnCollisionEnter(Collision collision)
    {
        if (!litFire && collision.gameObject.CompareTag("FireRock"))
        {
            fire.transform.position = new Vector3(transform.position.x, player.transform.position.y + 0.2f, transform.position.z);
            fire.transform.up = Vector3.up;
                fire.SetActive(true);
            fire.transform.SetParent(null);
            litFire = true;
        }
    }
}
