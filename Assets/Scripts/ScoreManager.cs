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
    public int score = 40;
    int highscore = 0;
    public QuickTimeEventMove QTEM;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        ScoreText.text = score.ToString() + " POINTS";
        HighScoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + " POINTS";
        QuickTimeEventMove.QTEMInstance.CreateSingleBox();
    }
    public void CompleteLevel()
    {
        if (score==216)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
