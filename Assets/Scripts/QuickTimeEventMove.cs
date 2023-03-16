using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEventMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private CircleCollider2D cc;
    public GameObject objectToSpawn;
    public ScoreManager SM;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateBoxes", 5);
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }
    public void CreateBoxes()
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
        if (transform.gameObject.name.Contains("Clone") && collision.gameObject.name == "ObjectTouchpoint")
        {
            Object.Destroy(transform.gameObject);
            Invoke("CreateBoxes", 5);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (transform.gameObject.name.Contains("Clone") && collision.gameObject.name == "LaunchOffSet")
        {
            Object.Destroy(transform.gameObject);
            ScoreManager.instance.AddPoint();
        }
        
    }
}
