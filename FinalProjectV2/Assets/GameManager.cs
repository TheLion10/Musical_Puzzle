using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject terrainLayer;
    public GameObject grassLayer;

    public void LoadGrassLayer()
    {
        Invoke("RemoveTerrainLayer", 8);
        grassLayer.SetActive(true);
    }

    private void RemoveTerrainLayer()
    {
        terrainLayer.SetActive(false);
    }
}