using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Grasshopper : MonoBehaviour
{
    [Header("Jump")]
    public float forceUp;
    public float forceRight;
    public float timeToJump;

    [Header("Raycast")]
    public Transform groundCheck;
    public LayerMask GetLayer;
    public float rayLegth;
    public bool isGrounded;

    int direction;
    Rigidbody2D rb2D;
    Animator anim;
    SpriteRenderer spriteRenderer;
    float timer;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        direction = 1;

    }

 
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToJump) Jump();

        isGrounded = Physics2D.Raycast(groundCheck.position, Vector2.down, rayLegth, groundLayer);
        Animating();
    }

    void Animating()
    {
        anim.SetFloat("YVelocity", rb2D.velocity.y);
        anim.SetBool("IsGrounded", isGrounded);
    }

    void Jump()
    {
        timer = 0;
        direction *= -1;
        Flip();
        rb2D.AddForce(Vector2.up * forceUp, ForceMode2D.Impulse);
        rb2D.AddForce(Vector2.right * forceRight * direction, ForceMode2D.Impulse);
    }

    void Flip()
    {

    }
}*/
