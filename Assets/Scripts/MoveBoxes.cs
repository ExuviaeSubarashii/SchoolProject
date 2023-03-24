using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxes : MonoBehaviour
{
    public static MoveBoxes MBInstace;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    public float speed;
    private void Awake()
    {
        MBInstace = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //speed += 1;
        rb.velocity = rb.velocity.normalized * QuickTimeEventMove.QTEMInstance.speed;
        //rb.velocity = new Vector2(-2f, -2f);
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
