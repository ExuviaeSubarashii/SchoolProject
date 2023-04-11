using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishWithMusic : MonoBehaviour
{
    public float duration=0.0f;
    void Update()
    {
        duration += Time.deltaTime;
        int seconds = (int)(duration % 60);
        if (SceneManager.GetActiveScene().buildIndex == 2 && seconds == 30)
        {
            ScoreManager.instance.CompleteLevel();
        }
        if (SceneManager.GetActiveScene().buildIndex == 3 && seconds == 30)
        {
            ScoreManager.instance.CompleteLevel();
        }
    }
}
