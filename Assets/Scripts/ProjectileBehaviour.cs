using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public Collider2D mycollider;
    void Start()
    {
        DisableCollidor();
        mycollider = GetComponent<Collider2D>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    public void EnableCollidor()
    {
        mycollider.enabled = true;
    }
    public void OnAttack()
    {
        EnableCollidor();
        Invoke("DisableCollidor",0.2f);
    }
    public void DisableCollidor()
    {
        mycollider.enabled = false;
    }
}
