using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishWithMusic : MonoBehaviour
{
    public float duration = 0.0f;
    public int seconds = 0;
    public int minutes = 0;
    private void Update()
    {
        duration += Time.deltaTime;

        minutes = Mathf.FloorToInt(duration / 60F);
        seconds = Mathf.FloorToInt(duration - minutes * 60);

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (minutes == 2 && seconds == 55)
            {
                ScoreManager.instance.CompleteLevel();
                Debug.Log("Level 1 Complete");
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 3  )
        {
            if (minutes == 4 && seconds == 04)
            {
                ScoreManager.instance.CompleteLevel();
                Debug.Log("Level 2 Complete");
            }
        }
    }
}
