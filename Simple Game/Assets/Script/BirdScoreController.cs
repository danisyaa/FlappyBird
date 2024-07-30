using UnityEngine;

public class BirdScoreController : MonoBehaviour
{
    public IScoreView scoreView;
    public int score;

    private void Start()
    {
        scoreView = FindObjectOfType<ScoreView>();
        if (scoreView == null)
        {
            Debug.LogError("ScoreView not found!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            score++;
            scoreView?.UpdateScore(score);
        }
    }
}
