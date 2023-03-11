using UnityEngine;

public class RootBehaviour : MonoBehaviour
{
    public GameObject staticRoot;

    public void Stop()
    {
        // GetComponent<"XRGrabInteractable">().enabled = false;
        gameObject.SetActive(false);
        staticRoot.SetActive(true);
    }
}
