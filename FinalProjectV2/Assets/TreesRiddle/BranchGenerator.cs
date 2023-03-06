using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchGenerator : MonoBehaviour
{
    public GameObject branch;
    private int rootsCounter = 0;

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
