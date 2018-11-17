using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    bool onGround = true;
    public float speed = 5f;
    public Vector2 jump;
    public Rigidbody2D active;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        PlayerOne();

    }
    void OnCollisionEnter2D(Collision2D variable)
    {
        if (variable.gameObject.tag == "ground")
        {
            onGround = true;
        }
       
    }
    void PlayerOne()
    {
        if(gameObject.tag=="Player 1")
        {
            if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow)))
            {
                float input = Input.GetAxis("Horizontal");
                transform.position = transform.position + new Vector3(input * speed * Time.deltaTime, 0, 0);
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if(onGround)
                    {
                        active.AddForce(jump, ForceMode2D.Impulse);
                        onGround = false;
                    }
                   
                }

            }
        }
    }
  
}