using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEventMove : MonoBehaviour
{
    public static QuickTimeEventMove QTEMinstance;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private CircleCollider2D cc;
    public GameObject objectToSpawn;
    public ScoreManager SM;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        Invoke("CreateBoxes", 5f);
        
    }
    public void CreateMultipleBoxes()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
    public void CreateSingleBox()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
    private void FixedUpdate()
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
