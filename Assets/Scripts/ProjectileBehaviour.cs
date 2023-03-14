using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed = 4.5f;
    public Collider2D mycollider;
    void Start()
    {
        //EnableCollidor();
        mycollider = GetComponent<Collider2D>();
    }
    void Update()
    {
        //transform.position += -transform.right * Time.deltaTime * speed;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    public void EnableCollidor()
    {
        //rb.velocity = new Vector2(dirX * movespeed, rb.velocity.y);
        //if (Input.GetButtonDown("Jump"))
        //{
        //    Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        //    LOS.SetActive(true);
        //}
        mycollider.enabled = true;
    }
    public void OnAttack()
    {
        EnableCollidor();
        //Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        Invoke("DisableCollidor",0.1f);
    }
    public void DisableCollidor()
    {
        mycollider.enabled = false;
    }
}
