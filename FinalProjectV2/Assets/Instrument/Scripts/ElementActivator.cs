using UnityEngine;

public class ElementActivator : MonoBehaviour
{
    public GameObject energyPoint;
    
    public void Activate()
    {
        energyPoint.SetActive(true);
    }

    public void Deactivate()
    {
        energyPoint.SetActive(false);
    }
}
