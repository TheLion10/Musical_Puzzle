using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject terrainLayer;
    public GameObject grassLayer;
    
    public void LoadGrassLayer()
    {
        terrainLayer.SetActive(false);
        grassLayer.SetActive(true);
    }
}
