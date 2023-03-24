using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelectionCollider : MonoBehaviour
{
    private BoxCollider2D bc;
    public SpriteRenderer rend;
    GameObject Player;
    public Sprite OpenSprite;
    public Sprite CloseSprite;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        Player = GameObject.Find("Player");
        //Door1 = GameObject.Find("Level1");
        //Door2 = GameObject.Find("Level2");
        //Door1.GetComponent<SpriteRenderer>().sprite = OpenDoor;
        //Door2.GetComponent<SpriteRenderer>().sprite = OpenDoor;
        rend = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
    }
    void ChangeSprite()
    {
        if (Vector3.Distance(Player.transform.position,this.transform.position)<3)
        {
            rend.sprite = OpenSprite;
        }
        else if (Vector3.Distance(Player.transform.position, this.transform.position) < 3)
        {
            rend.sprite = OpenSprite;
        }
        else
        {
            rend.sprite = CloseSprite;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.gameObject.name == "Level1" && collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Level 1");
        }
        else if (transform.gameObject.name == "Level2" && collision.gameObject.name == "Player")
        {   
            SceneManager.LoadScene("Level 2");
        }
    }
}
