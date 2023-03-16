using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public ProjectileBehaviour projectileBehaviour;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private BoxCollider2D coll;
    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffSet;
    [SerializeField] private LayerMask jumpableGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    //[SerializeField] private float movespeed = 7f;
    //private enum MovementState { idle, running, jumping, falling };

    // Update is called once per frame
    void Update()
    {
        UpdateAnimationState();
    }
    private void UpdateAnimationState()
    {
        //top object
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = new Vector2(-9.2f, 5.14f);
            projectileBehaviour.OnAttack();
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
        //mid object
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(-9.05f, 0.93f);
            projectileBehaviour.OnAttack();
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
        //bottom object
        if (Input.GetKey(KeyCode.E))
        {
            transform.position = new Vector2(-9.05f, -2.94f);
            projectileBehaviour.OnAttack();
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
