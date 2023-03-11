using UnityEngine;

public class BranchGenerator : MonoBehaviour
{
    public GameObject branch;
    private int rootsCounter;

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
