using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject terrainLayer;
    public GameObject grassLayer;
    public GameObject mushroomLayer;
    
    public void LoadGrassLayer()
    {
        terrainLayer.SetActive(false);
        grassLayer.SetActive(true);
    }
    public void LoadMushroomLayer()
    {
        mushroomLayer.SetActive(true);
        Invoke("RemoveGrassLayer", 10);
    }

    private void RemoveGrassLayer()
    {
        grassLayer.SetActive(false);
    }
}
