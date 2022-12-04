using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Gator : MonoBehaviour
{
    public Transform[] positions;

    [Header("Speed")]
    public float speed;
    public float speedMax;
    public float speedMovement;
    public float factorSpeedAttack;

    [Header("Attack")]
    public int damage;
    public float timeToAttackPlayer;
    public GameObject player;

    Vector3[] points;
    Vector3 posToGo;
    SpriteRenderer spriteRenderer;
    CircleCollider2D circleCollider;
    int i;
    float timer;
    bool attacking;
    PlayerHealth playerHealth;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        circleCollider = GetComponent<CircleCollider2D>();
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    void Start()
    {
        speed = speedMovement;

        points = new Vector3[positions.Length];
        for (int i = 0; i < positions.Length; i++)
        {
            points[i] = positions[i].position;
        }

        posToGo = points[0];
    }

  
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= timeToAttackPlayer && playerHealth.currentHealth > 0)
        {
            Attack();
        }

        ChangeTargetPos();
        transform.position = Vector3.MoveTowards(transform.position, posToGo, speed * Time.deltaTime);
        Flip();
    }

    void Attack()
    {
        if (attacking == false) 
        { 
            posToGo = player.transform.position;
            circleCollider.enabled = true;
            attacking = true;
        }
        
        float distance = Vector2.Distance(transform.position, posToGo);
        speed = speedMovement * (1 / distance) * factorSpeedAttack;
        speed = Mathf.Clamp(speed, speedMovement, speedMax);

        if(transform.position == posToGo)
        {
            timer = 0;
            attacking = false;
        }
    }

    void ChangeTargetPos()
    {
        if (attacking == true)
        {
            return;
        }

        speed = speedMovement;
        circleCollider.enabled = false;

        if (transform.position == posToGo)
        {
            i = Random.Range(0, points.Length);
            posToGo = points[i];
        }
    }

    void Flip()
    {
        if (posToGo.x > transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else if (posToGo.x < transform.position.x)
        {
            spriteRenderer.flipX = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
        }
    }
}*/
