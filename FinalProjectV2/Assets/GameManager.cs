using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject terrainLayer;
    public GameObject grassLayer;
    public GameObject[] emmiters;
    private bool[] playingEmmiters = {false};

    public void LoadGrassLayer()
    {
        Invoke("RemoveTerrainLayer", 8);
        grassLayer.SetActive(true);
    }

    private void RemoveTerrainLayer()
    {
        terrainLayer.SetActive(false);
    }

    public void AddSoundLayer(int layerNum)
    {
        playingEmmiters[layerNum] = true;
        ResetSoundLayers();
    }
    public void RemoveSoundLayer(int layerNum)
    {
        playingEmmiters[layerNum] = false;
        emmiters[layerNum].SetActive(false);
    }

    private void ResetSoundLayers()
    {
        for (int i = 0; i < 5; i++)
        {
            emmiters[i].SetActive(false);
            if (playingEmmiters[i])
            {
                emmiters[i].SetActive(true);
            }
        }
    }
}