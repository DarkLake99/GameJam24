using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPoints : MonoBehaviour {

    // Use this for initialization
    public float hp = 100f;
    public GameManager gameEffect;
    public GameObject play1win;
    public GameObject play2win;


    // Update is called once per frame
    void Update () 
    {
        if(hp<=0)
        {
            Death();
        }

	}
    void Death()
    {
        Destroy(gameObject);
        gameEffect.LoadScene(2);
        if(gameObject.tag=="Player 1" && hp<=0)
        {
            play2win.SetActive(true);
        }else if(gameObject.tag=="Player 2"&& hp<=0)
        {
            play1win.SetActive(true);
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bullet")
        {
            hp--;
        }
    }
    
}
