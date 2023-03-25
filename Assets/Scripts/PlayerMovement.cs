using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    void Update()
    {
        UpdateAnimationState();
    }
    private void UpdateAnimationState()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector2(-9.2f, 5.14f);
            projectileBehaviour.OnAttack();
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector2(-9.05f, 0.93f);
            projectileBehaviour.OnAttack();
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector2(-9.05f, -2.94f);
            projectileBehaviour.OnAttack();
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Level_Select");
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
