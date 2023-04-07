using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTimeEventAppear : MonoBehaviour
{
    public static QuickTimeEventAppear instance;
    public Text RandomLetter;
    public string Score;
    KeyCode myKeyCode;
    char c;
    string myString;
    //public GameObject QTE;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        RandomLetter.text = "";
        myKeyCode = (KeyCode)c;
    }
    public void InstantiateQTE()
    {
        SetRandomLetter();
    }
    public void CheckIfCorrectLetter()
    {
        if (System.Enum.TryParse(myString, out myKeyCode))
        {
            if (Input.GetKey(myKeyCode))
            {
                //Debug.Log("Hello, A was pressed");
                SetRandomLetter();
                ScoreManager.instance.AddPoint();
            }
        }

    }
    public void SetRandomLetter()
    {
        c = (char)('A' + Random.Range(0, 26));
        RandomLetter.text = c.ToString();
        myString = RandomLetter.text;
    }
    void Update()
    {
        CheckIfCorrectLetter();
        //Score = ScoreManager.instance.score.ToString();
    }
}
