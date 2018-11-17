using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPolarity : MonoBehaviour {
    public bool positiveSide;
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Portal")
        {
            if (positiveSide)
            {
                positiveSide = false;
            }
            else
            {
                positiveSide = true;
            }
            Destroy(collision.gameObject);
        }
    }
   
    public string CheckString()
    {
        if (positiveSide)
        {
            return "true";
        }
        else
        {
            return "false";
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
