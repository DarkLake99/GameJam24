using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Guns : MonoBehaviour {

    public bool haveGun = false;
    public Transform firePoint;
    public GameObject bulletPrefab;

    public string fireButton = "Fire1";
    //public movement playerControl;
    public PlatformerCharacter2D characterController;

    public movement playerControl;

    private float bulletVelocity;
    private float bulletDistance;
    public AudioSource pistolGun;
    public AudioSource laserGun;
    public AudioSource blastGun;


    // Update is called once per frame
    void Update()
        {
        if (haveGun)
        {
            if (Input.GetButtonDown(fireButton))
            {
                Shoot();
            }
        }
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pistol")
        {
            bulletDistance = 8f;
            bulletVelocity = 20f;
            Destroy(collision.gameObject);
            bulletPrefab = Resources.Load("bullet1") as GameObject;
            haveGun = true;
        }
        if (collision.gameObject.tag == "Laser")
        {
            bulletDistance = 20f;
            bulletVelocity = 30f;
            Destroy(collision.gameObject);
            bulletPrefab = Resources.Load("Laser") as GameObject;
            haveGun = true;
        }
        if (collision.gameObject.tag == "Blast")
        {
            bulletDistance = 2f;
            bulletVelocity = 30f;
            Destroy(collision.gameObject);
            bulletPrefab = Resources.Load("Blast") as GameObject;
            haveGun = true;
        }
    }
    void Shoot()
        {
        if(gameObject.tag=="pistolBullet")
        {
            pistolGun.Play();
        }
        else if(gameObject.tag == "Laser")
        {
            laserGun.Play();
        }
        else if(gameObject.tag == "Blast")
        {
            blastGun.Play();
        }
       
        //shooting logic
            GameObject bullet = GameObject.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * bulletVelocity * ((characterController.m_FacingRight) ? 1 : -1);
            bullets b = bullet.GetComponent<bullets>();
            b.lifeTime = bulletDistance / bulletVelocity;
            b.InvokeDestroySelf();
        }

}
