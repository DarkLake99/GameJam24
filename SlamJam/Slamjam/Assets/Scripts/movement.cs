using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    bool onGround = true;
    public float speed = 5f;
    public float jump = 5f;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        PlayerOne();
        PlayerTwo();
        float input = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(input * speed * Time.deltaTime, 0, 0);
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

        }
    }
    void PlayerTwo()
    {
        if(gameObject.tag=="Player 2")
        {

        }
    }
}