using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public int misses = 0;
    public int maxMisses = 10;  // game over after 10 misses
    public int winScore = 15;   // win after 15 pops

    public Text scoreText;
    public Text gameOverText;

    void Awake()
    {
        instance = this;
        gameOverText.gameObject.SetActive(false); // hide at start
        scoreText.text = "Score: 0";
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;

        if (score >= winScore)
        {
            GameOver("You Win!");
        }
    }

    public void MissBubble()
    {
        misses++;
        if (misses >= maxMisses)
        {
            GameOver("Game Over!");
        }
    }

    void GameOver(string message)
    {
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = message;
        Time.timeScale = 0f; // pause game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
