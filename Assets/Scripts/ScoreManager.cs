using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text ScoreText;
    public Text HighScoreText;
    string HitOrmiss;
    public int score = 1;
    int highscore;
    public TextWriter fs;
    string path = "";
    string content = "";
    void Awake()
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
        QuickTimeEventAppear.instance.SetRandomLetter();
    }
    public void AddTwoPoints()
    {
        score += 2;
        ScoreText.text = score.ToString() + " POINTS";
        QuickTimeEventAppear.instance.SetRandomLetter();
    }
    public void AddThreePoints()
    {
        score += 3;
        ScoreText.text = score.ToString() + " POINTS";
        QuickTimeEventAppear.instance.SetRandomLetter();
    }
    public void CompleteLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            path = @"./Assets/Scoreboards/Level1Scoreboard.txt";
            content = score.ToString();
            File.WriteAllText(path, content);
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            path = @"./Assets/Scoreboards/Level2Scoreboard.txt";
            content = score.ToString();
            File.WriteAllText(path, content);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
