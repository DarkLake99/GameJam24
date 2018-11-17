using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthPoints : MonoBehaviour
{

    // Use this for initialization
    public float hp = 100f;
    public float damage = 2f;
    private bool invisible=false;
   
    public float timeOut=10f;
    public float saveTime;
    //  public GameManager gameEffect;
    //public GameObject play1win;
    //public GameObject play2win;
    //public PlayerPolarity portal;
     void Start()
    {
        saveTime = timeOut;
    }

    // Update is called once per frame
    void Update()
    {
        if(invisible)
        {
            timeOut -= Time.deltaTime;
        }
       
        if (hp <= 0 || timeOut <= 0)
        {
            Death();
        }
       
    }
    void Death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }

    void OnTriggerEnter2D(Collider2D bulletHit)
    {
        if (bulletHit.gameObject.tag == "Bullet" )
        {
            // Debug.Log(bulletHit.name);
            //Debug.Break();
            hp = hp - damage;
        }

    }
    void OnBecameInvisible()
    {
        saveTime = timeOut;
        invisible = true;
    }
     void OnBecameVisible()
    {
       invisible = false;
        timeOut = saveTime;
    }
}