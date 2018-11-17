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
    public GameObject player1;
    public GameObject player2;
    void Start()
    {
        saveTime = timeOut;
    }

    // Update is called once per frame
    void Update()
    {
        if (invisible)
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
        string checkPlayer1 = player1.GetComponent<PlayerPolarity>().CheckString();
        string checkPlayer2 = player2.GetComponent<PlayerPolarity>().CheckString();
        if (checkPlayer1 == checkPlayer2)
        {
            if (bulletHit.gameObject.tag == "PistolBullet")
            {
                damage = 6f;
                // Debug.Log(bulletHit.name);
                //Debug.Break();
                hp = hp - damage;
            }
            else if (bulletHit.gameObject.tag == "LaserBullet")
            {
                damage = 4f;
                hp = hp - damage;
            }
            else if (bulletHit.gameObject.tag == "BlastBullet")
            {
                damage = 12f;
                hp = hp - damage;
            }
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