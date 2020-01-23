using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public float speed = .1f; 

    private void Start()
    {
        transform.position = playerTransform.position; 
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            transform.position = Vector2.Lerp(transform.position, playerTransform.position, speed);
        }
        
    }
}
