using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingUpGame : MonoBehaviour
{
    public GameObject Bird;
    public GameObject Score;
    public GameObject PipeSpawner;
    public GameObject StartTab;

    bool Start = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !Start)
        {
            StartingGame();
        }
    }

    void StartingGame()
    {
        Start = true;
        PipeSpawner.SetActive(true);
        Bird.SetActive(true);
        Score.SetActive(true);
        StartTab.SetActive(false);
    }


}
