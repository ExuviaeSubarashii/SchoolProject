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
    public Text HitOrMiss;
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
        //QuickTimeEventMove.QTEMInstance.CreateSingleBox();
    }
    public void AddTwoPoints()
    {
        score += 2;
        ScoreText.text = score.ToString() + " POINTS";
    }
    public void WhatEverTheFuck()
    {
        QuickTimeEventAppear.instance.InstantiateQTE();
    }
    public void CompleteLevel()
    {
        if (score == 216)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void IsItMiss()
    {
        HitOrMiss.text = "Miss";
    }
}
