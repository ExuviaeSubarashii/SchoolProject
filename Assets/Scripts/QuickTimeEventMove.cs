using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuickTimeEventMove : MonoBehaviour
{
    public static QuickTimeEventMove QTEMInstance;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private CircleCollider2D cc;
    public GameObject objectToSpawn;
    
    private void Awake()
    {
        QTEMInstance = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        //Invoke("CreateMultipleBoxes", 5f);
        //Invoke("CreateSingleBox", 10f);
        //Invoke("CreateMultipleBoxes", 15f);
        //Invoke("CreateSingleBox", 20f);
        //Invoke("CreateMultipleBoxes", 25f);
        //Invoke("CreateSingleBox", 30f);
        //Invoke("CreateMultipleBoxes", 35f);
        //Invoke("CreateSingleBox", 40f);
        //Invoke("CreateMultipleBoxes", 45f);
        StartCoroutine(Boxes());
    }
    //public void CreateMultipleBoxes()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    //    }
    //}
    public IEnumerator Boxes()
    {
        float IncreasingValue = 1f;
        for (int i = 0; i < 100; i++)
        {
            yield return new WaitForSeconds(IncreasingValue);
            IncreasingValue += 0.3f;
            MoveBoxes.MBInstace.speed += 3f;
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
    public IEnumerator CreateSingleBox()
    {
        float IncreasingValue = 1f;
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(IncreasingValue);
        IncreasingValue += 5;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(-2f, -2f);
        if (ScoreManager.instance.score == 40)
        {
            //ScoreManager.instance.CompleteLevel();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.gameObject.name.Contains("Clone") && collision.gameObject.name == "ObjectTouchpoint")
        {
            transform.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.gameObject.name.Contains("Clone") && collision.gameObject.name == "LaunchOffSet")
        {
            transform.gameObject.SetActive(false);
            ScoreManager.instance.AddPoint();
        }
    }
}
