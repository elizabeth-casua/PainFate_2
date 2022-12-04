using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*public class PlayerHealth : MonoBehaviour
{
    [Header("Health")]
    public float maxHealth;
    public float currentHealth;
    public float recoveryHealth;

    [Header("UI")]
    public Image acornUI;

    [Header("death")]
    public float forceJumDeath;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        currentHealth = MaxHealth;
        acornUI.fillAmount = 1;
    }

    //Public method to be call from enemy script
    public void TakeDamage(int amount)
    {
        if (anim.GetBool("Hurt") || currentHealth <= 0) return;

        currentHealth -= amount;
        acornUI.fillAmount = currentHealth / maxHealth;

        anim.SetBool("Hurt", true);
        playerMovement.resetVelocity();

        if(currentHealth <= 0)
        {
            Death();
            return;
        }
        Invoke("HurtToFalse", 1);
    }

    void Death()
    {
        GetComponent<CircleCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * forceJumDeath);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(Collision.CompareTag("Acorn"))
        {
            currentHealth += recoveryHealth;
            if (currentHealth > maxHealth) currentHealth = maxHealth;

            acornUI.fillAmount = currentHealth / maxHealth;

            Destroy(collision.gameObject);
        }
    }
}*/
