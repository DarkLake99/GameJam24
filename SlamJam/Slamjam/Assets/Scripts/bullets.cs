using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 3f;
    public Rigidbody2D rb;

    // Use this for initialization
    public void InvokeDestroySelf()
    {
        Invoke("DestroySelf", lifeTime);
    }
    void DestroySelf()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D bulletHit)
    {
        if (bulletHit.gameObject.tag == "platform" || bulletHit.gameObject.tag == "ground" || bulletHit.gameObject.name == "player1" || bulletHit.gameObject.name == "player2")
        {
            Debug.Log(bulletHit.name);
            //Debug.Break();
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
