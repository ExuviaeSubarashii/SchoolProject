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
    string HitOrmiss;
    public int score = 1;
    int highscore;
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
    }
    public void AddTwoPoints()
    {
        score += 2;
        ScoreText.text = score.ToString() + " POINTS";
    }
    public void AddThreePoints()
    {
        score += 3;
        ScoreText.text = score.ToString() + " POINTS";
        QuickTimeEventAppear.instance.SetRandomLetter();
    }
    public void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
