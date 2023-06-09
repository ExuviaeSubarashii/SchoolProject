using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        
        StartCoroutine(Boxes());
    }
    public IEnumerator Boxes()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
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
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            float IncreasingValue = Random.Range(1f, 3f);
            for (int i = 0; i < 350; i++)
            {
                yield return new WaitForSeconds(IncreasingValue);
                //IncreasingValue += 0.1f;
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
        //if (ScoreManager.instance.score == 30)
        //{
            
        //}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (name.Contains("Clone") && collision.name == "LaunchOffSet")
        {
            Debug.Log("collision.name == LaunchOffSet");
            transform.gameObject.SetActive(false);
            ScoreManager.instance.AddPoint();
        }
    }
}
