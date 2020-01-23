using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHand : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotPoint;
    public float timeBetweenShots;

    private float shotTime; 

    // Start is called before the first frame update
    void Start()
    {
        shotTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time >= shotTime)
            {
                Instantiate(projectile, shotPoint.position, transform.rotation);
                shotTime = Time.time + timeBetweenShots;
                Debug.Log("Shottime: " + shotTime);
                Debug.Log("Time between shots: " + timeBetweenShots); 
            }
        }
    }
}
