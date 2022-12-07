using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPro : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    public float acceleration;

    Animator anim;
    Rigidbody2D rb2D;
    SpriteRenderer spriteRenderer;
    Vector2 targetVelocity; //Speed I would like for the target
    Vector3 dampVelocity; //Where I'm going to keep actual target speed

    float h;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        InputPlayer();
        TargetVelocity();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, targetVelocity, ref dampVelocity, acceleration);
    }

    void InputPlayer()
    {
        h = Input.GetAxis("Horizontal");
    }

    void TargetVelocity()
    {
        targetVelocity = new Vector2(h * speed, rb2D.velocity.y);
    }
}
