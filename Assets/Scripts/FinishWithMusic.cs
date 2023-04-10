using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishWithMusic : MonoBehaviour
{
    public float duration;
    void Update()
    {
        duration += Time.deltaTime;
        if ( duration==175|| duration==280)
        {
            ScoreManager.instance.CompleteLevel();
        }
    }
}
