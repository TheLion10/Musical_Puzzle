using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchGenerator : MonoBehaviour
{
    public GameObject branch;
    private int rootsCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Increase()
    {
        rootsCounter++;
        if (rootsCounter == 3)
        {
            Invoke("CreateBranch", 1);
        }
    }

    void CreateBranch()
    {
        branch.SetActive(true);
    }
}
