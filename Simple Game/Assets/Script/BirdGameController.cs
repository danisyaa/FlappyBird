using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGameController : MonoBehaviour
{
    private IGameOverHandler gameOverHandler;

    private void Start()
    {
        gameOverHandler = FindObjectOfType<GameOverHandler>();
        if (gameOverHandler == null)
        {
            Debug.LogError("GameOverHandler not found!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            Destroy(gameObject);
            gameOverHandler?.HandleGameOver();
        }
    }
}
