using UnityEngine;

public class HillDigger : MonoBehaviour
{
    public GameObject player;
    public GameObject hill;
    private bool canDig = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (canDig && collision.gameObject.CompareTag("Ground"))
        {
            hill.transform.position = new Vector3(transform.position.x, -0.05f, transform.position.z);
            hill.transform.eulerAngles = player.transform.eulerAngles - Vector3.right * 90;
            hill.SetActive(true);
            canDig = false;
        }
    }
}
