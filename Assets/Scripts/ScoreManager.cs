using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text ScoreText; 
    public Text HighScoreText;
    int score = 0;
    int highscore = 0;
    public QuickTimeEventMove QTEM;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString()+" POINTS";
        HighScoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + " POINTS";
    }
    public void CreateBoxesWhenScoreIsDividible()
    {
        if (score/2==0)
        {
            QTEM.CreateBoxes();
        }
    }
}
