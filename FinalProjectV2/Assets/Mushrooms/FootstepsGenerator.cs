using UnityEngine;

public class FootstepsGenerator : MonoBehaviour
{
    public GameObject[] paws;
    private int pawIdx;

    private int waitTime;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject paw in paws)
        {
            Invoke("Generate", waitTime);
            waitTime += 2;
        }
    }

    void Generate()
    {
        paws[pawIdx].SetActive(true);
        pawIdx++;
    }
}
