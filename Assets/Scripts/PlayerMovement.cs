using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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
        coll = GetComponent<BoxCollider2D>();
    }
    float dirX = 0;
    [SerializeField] private float movespeed = 7f;
    [SerializeField] private float jumpforce = 14f;
    private enum MovementState { idle, running, jumping, falling };
    // Update is called once per frame
    void Update()
    {
        //dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * movespeed, rb.velocity.y);
        //if (Input.GetButtonDown("Jump") && IsGrounded()==true)
        //{
        //    rb.velocity = new Vector3(rb.velocity.x, jumpforce);
        //}
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        //character movements

        //MovementState state;
        //if (dirX > 0f)
        //{
        //    state = MovementState.running;
        //    sprite.flipX = false;
        //}
        //else if (dirX < 0f)
        //{
        //    state = MovementState.running;
        //    sprite.flipX = true;
        //}
        //else
        //{
        //    state = MovementState.idle;
        //}
        //if (rb.velocity.y > .1f)
        //{
        //    state = MovementState.jumping;
        //}
        //else if (rb.velocity.y < -.1f)
        //{
        //    state = MovementState.falling;
        //}
        //anim.SetInteger("state", (int)state);

        //top object
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = new Vector2(-9.2f, 5.14f);
        }
        //mid object
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(-9.05f, 0.93f);
        }
        //bottom object
        if (Input.GetKey(KeyCode.E))
        {
            transform.position = new Vector2(-9.05f, -2.94f);
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
