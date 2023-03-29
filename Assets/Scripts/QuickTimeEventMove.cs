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
    public float speed = 1f;
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
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            float IncreasingValue = Random.Range(1f, 2f);
            for (int i = 0; i < 300; i++)
            {
                yield return new WaitForSeconds(IncreasingValue);
                //IncreasingValue += 0.3f;
                speed += 0.1f;
                Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            float IncreasingValue = Random.Range(1f, 5f);
            for (int i = 0; i < 350; i++)
            {
                yield return new WaitForSeconds(IncreasingValue);
                IncreasingValue += 0.3f;
                speed += 0.1f;
                Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            }
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
        rb.velocity = rb.velocity.normalized * speed;
        //rb.velocity = new Vector2(-2f, -2f);
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
        if (transform.gameObject.name.Contains("Clone") && collision.gameObject.name == "LaunchOffSet" && collision.contactCount > 2)
        {
            ScoreManager.instance.AddTwoPoints();
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
