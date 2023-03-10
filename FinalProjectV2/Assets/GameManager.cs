using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject terrainLayer;
    public GameObject grassLayer;
    public GameObject mushroomLayer;
    public GameObject flowerLayer;
    public GameObject treeLayer;
    public GameObject waterLayer;
    
    public void LoadGrassLayer()
    {
        Invoke("RemoveTerrainLayer", 10);
        grassLayer.SetActive(true);
    }
    public void LoadMushroomLayer()
    {
        mushroomLayer.SetActive(true);
        // Invoke("RemoveGrassLayer", 10);
    }
    public void LoadFlowerLayer()
    {
        flowerLayer.SetActive(true);
        // Invoke("RemoveMushroomLayer", 10);
    }
    
    public void LoadTreeLayer()
    {
        treeLayer.SetActive(true);
    }
    
    public void LoadWaterLayer()
    {
        waterLayer.SetActive(true);
    }

    private void RemoveGrassLayer()
    {
        grassLayer.SetActive(false);
    }
    private void RemoveMushroomLayer()
    {
        mushroomLayer.SetActive(false);
    }
    private void RemoveTerrainLayer()
    {
        terrainLayer.SetActive(false);
    }
}
