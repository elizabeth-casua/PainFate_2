using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float distanceX;
    public float smothing;

    Transform cam;
    Vector3 previousCamPos;

    void Start()
    {
        cam = Camera.main.transform;
        previousCamPos = cam.position;
    }

    
    void Update()
    {
        if(distanceX !=0)
        {
            float parallaxX = (previousCamPos.x - cam.position.x) * distanceX;
            Vector3 backgroundTargetPosX = new Vector3(transform.position.x + parallaxX, transform.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, backgroundTargetPosX, smothing * Time.deltaTime);
            previousCamPos = cam.position;
        }
    }
}
