﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed;
    public float lifeTime;

    public GameObject explosion; 

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); 
    }

    private void DestroyProjectile()
    {
        Instantiate(explosion, transform.position, Quaternion.identity); 
        Destroy(gameObject);
    }
}
