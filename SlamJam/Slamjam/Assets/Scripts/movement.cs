using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    bool onGround = true;
    public float speed = 5f;
    public Vector2 jump;
    public Rigidbody2D active;
    public bool facingRight = true;
    public string HorizontalAxis = "Horizontal";
    public string VerticalAxis = "Jump";

    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        Player();

    }
    void OnCollisionEnter2D(Collision2D variable)
    {
        if (variable.gameObject.tag == "ground")
        {
            onGround = true;
        }
       
    }
    void Player()
    {
        if(Input.GetButton(HorizontalAxis)||Input.GetButtonDown(VerticalAxis))
        {
            float horz = Input.GetAxis(HorizontalAxis);
            float vert = Input.GetAxis(VerticalAxis);
         
            if (Mathf.Abs(horz) > 0||Mathf.Abs(vert)>0)
            {
               
                transform.position = transform.position + new Vector3(horz * speed * Time.deltaTime, 0, 0);
                if (Input.GetButtonDown(VerticalAxis))
                {
                    Debug.Log("Entered Jump code");
                    if (onGround)
                    {
                        active.AddForce(jump, ForceMode2D.Impulse);
                        onGround = false;
                    }

                }

                if (horz > 0 && !facingRight)
                {                   
                    Flip();
                    //transform.position = transform.position + new Vector3(horz * speed * Time.deltaTime, 0, 0);
                }
                else if (horz < 0 && facingRight)
                {                   
                    Flip();
                   // transform.position = transform.position + new Vector3(horz * speed * Time.deltaTime, 0, 0);
                }
            }
           

        }
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}