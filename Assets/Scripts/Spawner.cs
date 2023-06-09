using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(-2f, -2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.gameObject.name == objectToSpawn.transform.name && collision.gameObject.name == "ObjectTouchpoint")
        {
            rb.position = new Vector2(9.31f, 4.68f);
        }
    }
}
