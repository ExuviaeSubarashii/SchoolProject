using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTimeEventAppear : MonoBehaviour
{
    public static QuickTimeEventAppear instance;
    public Text RandomLetter;
    public int Score;
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
        SetRandomLetter();
    }
    public void CheckIfCorrectLetter()
    {
        if (System.Enum.TryParse(myString, out myKeyCode))
        {
            if (Input.GetKeyDown(myKeyCode))
            {
                //myKeyCode = KeyCode.None;
                RandomLetter.text = null;
                ScoreManager.instance.AddTwoPoints();
                SetRandomLetter();
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
    }
}
