using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelectionCollider : MonoBehaviour
{
    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
