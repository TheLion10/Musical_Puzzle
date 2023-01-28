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
        grassLayer.SetActive(false);
        mushroomLayer.SetActive(true);
    }
}
