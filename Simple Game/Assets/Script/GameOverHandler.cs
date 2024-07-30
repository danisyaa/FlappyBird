using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverHandler : MonoBehaviour, IGameOverHandler
{
    public GameObject gameOverScreen;

    public void HandleGameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
