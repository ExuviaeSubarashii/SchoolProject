using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxes : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(-2f, -2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.gameObject.name.Contains("Clone") && collision.gameObject.name == "ObjectTouchpoint")
        {
            Destroy(transform.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.gameObject.name.Contains("Clone") && collision.gameObject.name == "LaunchOffSet")
        {
            Destroy(transform.gameObject);
            ScoreManager.instance.AddPoint();
        }
    }
}
