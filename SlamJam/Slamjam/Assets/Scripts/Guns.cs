using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Guns : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public string fireButton = "Fire1";
    //public movement playerControl;
    public PlatformerCharacter2D characterController;
    public float bulletVelocity = 10f;
    public float bulletDistance = 3f;
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetButtonDown(fireButton))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        //shooting logic
        GameObject bullet = GameObject.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletVelocity * ((characterController.m_FacingRight)? 1 : -1);
        bullets b = bullet.GetComponent<bullets>();
        b.lifeTime =  bulletDistance / bulletVelocity;
        b.InvokeDestroySelf();
    }

}
