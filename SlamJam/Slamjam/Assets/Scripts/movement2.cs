using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour {

    // Use this for initialization
    bool onGround = true;
    public float speed = 5f;
    public Vector2 jump;
    public Rigidbody2D active2;

    // Update is called once per frame
    void Update () 
    {
        PlayerTwo();
    }
    void OnCollisionEnter2D(Collision2D variable)
    {
        if (variable.gameObject.tag == "ground")
        {
            onGround = true;
        }
    }
    void PlayerTwo()
    {
        if (gameObject.tag == "Player 2")
        {
            if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
            {
                float move = Input.GetAxis("Horizontal-2");
                transform.position = transform.position + new Vector3(move * speed * Time.deltaTime, 0, 0);
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (onGround)
                    {
                        active2.AddForce(jump, ForceMode2D.Impulse);
                        onGround = false;
                    }

                }
            }
        }
    }
}
