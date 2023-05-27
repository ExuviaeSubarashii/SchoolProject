using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialPlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private BoxCollider2D coll;
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
    private enum MovementState { idle, running, jumping, falling };

    // Update is called once per frame
    void Update()
    {
        UpdateAnimationState();
        
    }
    private void FixedUpdate()
    {
        IsFlipped();
    }
    
    private void UpdateAnimationState()
    {
        //character movements
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * movespeed, rb.velocity.y);
        MovementState state;
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            
        //}
        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }
        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("HowToPlay");
        }
        anim.SetInteger("state", (int)state);
    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
    public void IsFlipped()
    {
        if (transform.rotation.z>0||transform.rotation.z<0)
        {
            transform.Rotate(new Vector3(0,0,0));
        }
    }
}