using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthPoints : MonoBehaviour {

    // Use this for initialization
    public float hp = 100f;
  //  public GameManager gameEffect;
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
        SceneManager.LoadScene(2);
       

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bullet")
        {
            hp--;
        }
    }
    
}
