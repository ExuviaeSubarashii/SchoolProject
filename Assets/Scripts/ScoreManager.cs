using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text ScoreText;
    public Text HighScoreText;
    public int score = 0;
    int highscore = 0;
    public QuickTimeEventMove QTEM;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString() + " POINTS";
        HighScoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + " POINTS";
    }
    public void CreateBoxesOnPoints()
    {
        if (score == 10)
        {
            QTEM.CreateSingleBox();
        }
    }
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
