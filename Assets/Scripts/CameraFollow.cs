using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothTargetTime;

    Vector3 smoothDampVelocity;
    PlayerHealth playerHealth;


    void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth.currentHealth <= 0)
        {
            return;
        }
        transform.position = Vector3.SmoothDamp(transform.position, player.position + offset, ref smoothDampVelocity, smoothTargetTime);
    }
}*/
