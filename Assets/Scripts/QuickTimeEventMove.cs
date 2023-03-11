using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEventMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        CreateBoxes();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void CreateBoxes()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(-2f, -2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (transform.gameObject.name == "QuickTimeEntityTop" && collision.gameObject.name == "ObjectTouchpoint" && Input.GetKey(KeyCode.Q))
        //{
        //    rb.position = new Vector2(9.31f, 4.68f);
        //}
        //else if (transform.gameObject.name == "QuickTimeEntityMid" && collision.gameObject.name == "ObjectTouchpoint" && Input.GetKey(KeyCode.W))
        //{
        //    rb.position = new Vector2(9.34f, 0.48f);
        //}
        //else if (transform.gameObject.name == "QuickTimeEntityBottom" && collision.gameObject.name == "ObjectTouchpoint" && Input.GetKey(KeyCode.E))
        //{
        //    rb.position = new Vector2(9.42f, -3.6f);
        //}
        ////if false
        //else if (transform.gameObject.name == "QuickTimeEntityTop" && collision.gameObject.name == "ObjectTouchpoint" && !Input.GetKey(KeyCode.Q))
        //{
        //    rb.position = new Vector2(9.31f, 4.68f);
        //}
        //else if (transform.gameObject.name == "QuickTimeEntityMid" && collision.gameObject.name == "ObjectTouchpoint" && !Input.GetKey(KeyCode.W))
        //{
        //    rb.position = new Vector2(9.34f, 0.48f);
        //}
        //else if (transform.gameObject.name == "QuickTimeEntityBottom" && collision.gameObject.name == "ObjectTouchpoint" && !Input.GetKey(KeyCode.E))
        //{
        //    rb.position = new Vector2(9.42f, -3.6f);
        //}


        if (transform.gameObject.name.Contains("Top") && collision.gameObject.name == "ObjectTouchpoint")
        {
            rb.position = new Vector2(9.31f, 4.68f);
        }
        else if (transform.gameObject.name.Contains("Mid") && collision.gameObject.name == "ObjectTouchpoint")
        {
            rb.position = new Vector2(9.34f, 0.48f);
        }
        else if (transform.gameObject.name.Contains("Bottom") && collision.gameObject.name == "ObjectTouchpoint")
        {
            rb.position = new Vector2(9.42f, -3.6f);
        }
    }
}
