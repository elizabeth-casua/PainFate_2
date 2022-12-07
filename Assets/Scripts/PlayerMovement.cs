using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public int speed;

    [Header("Raycast")]
    public Transform groundCheck; //Point of origin of the raycast
    public LayerMask groundLayer; //Layer where the platform ground is
    public float rayLenght; //Raycast lenght
    public bool isGrounded; //Variable for telling us if it is toching platform ground or not

    [Header("Jump")]
    public float jumpForce;

    [Header("Win")]
    public float timeForWinning;

    Rigidbody2D rb2D;
    SpriteRenderer spriteRenderer;
    Animator anim;

    bool canMove;
    float timer;
    bool jumpPressed;
    float h;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        canMove = true;
    }

    void Update()
    {
        //if (anim.GetBool("Hurt") == true) return;

        Movement();
        Flip();
        Animating();
        IsGrounded();
        JumpPressed();
        Attack();
        Win();
    }

    void FixedUpdate()
    {
        ChangeGravity();

        if(jumpPressed) Jump();
    }

    void JumpPressed()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true) jumpPressed = true;
    }

    void Jump()
    {
        jumpPressed = false;
        rb2D.AddForce(Vector2.up * jumpForce);
    }

    void IsGrounded()
    /*
     * A selective raycat (groundLayer detecting) is thrown out with rayLenght lenght,
     *and origin groundcheck and down direction on Y axis. The raycast is giving back a true
     *if is toching an object of groundLayer
     */
    {
        isGrounded = Physics2D.Raycast(groundCheck.position, Vector2.down, rayLenght, groundLayer);

        Debug.DrawRay(groundCheck.position, Vector2.down * rayLenght, Color.red);
    }

    void Movement()
    {
        h = Input.GetAxis("Horizontal");

        if(canMove)
        transform.Translate(h * speed * Time.deltaTime * Vector2.right);
    }

    void Flip()
    {
        if(h > 0) spriteRenderer.flipX = false; //if i'm going to the right
        else if(h < 0) spriteRenderer.flipX = true; //if i'm going to the left
    }

    void ChangeGravity()
    {
        if(rb2D.velocity.y < 0) rb2D.gravityScale = 1.5f;
        else rb2D.gravityScale = 1;
    }

    void Animating()
    {
        if(h != 0) anim.SetBool("IsMoving", true);
        else anim.SetBool("IsMoving", false);

        //IsJumping is taking the opposite value of isGrounded
        anim.SetBool("IsJumping", !isGrounded);
    }

    void Attack()
    {
        //If pressing button E and player is standing
        if(Input.GetKey(KeyCode.E) && h == 0) 
        {
            canMove = false;
            anim.SetTrigger("Attack");
        }
    }

    void Win()
    {
        //If player is standing
        if(h == 0) 
        {
            timer += Time.deltaTime;
            if(timer >= timeForWinning) 
            {
                timer = 0;
                canMove = false;
                anim.SetTrigger("Win");
            }
        }
        //If player is moving
        else timer = 0;
    }


    void CanMoveToTrue()
    {
        canMove = true;
    }

    public void ResetVelocity()
    {

    }


}

