using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matt_Movement : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    bool isGrounded = false; 
    public Transform isGroundedChecker; 
    public float checkGroundRadius; 
    public LayerMask groundLayer;
    float fallZone = -10f;
    public Transform playerSpawnPoint = null;
    public GameObject player;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal"); 
        float moveBy = x * speed; 
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded) 
        { 
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
        }
    }

    void CheckIfGrounded()
    { 
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer); 
        if (collider != null)
        { 
            isGrounded = true;
        }

        else
        { 
            isGrounded = false;
        } 
    }

    void Update()
    {
        Move();
        Jump();
        CheckIfGrounded();

        anim.SetBool("Jump", false);
        anim.SetBool("Jump left", false);
        anim.SetBool("Walk left", false);
        anim.SetBool("Walk right", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
            anim.SetBool("Jump left", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("Walk left", true);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Walk left", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Walk right", true);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Walk right", true);
        }

        if (player.transform.position.y < fallZone)
        {
            player.transform.position = playerSpawnPoint.position;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
