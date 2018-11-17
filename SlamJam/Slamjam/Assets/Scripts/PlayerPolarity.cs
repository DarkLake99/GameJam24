using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPolarity : MonoBehaviour {
    public bool positiveSide;
    // Use this for initialization
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (positiveSide)
        {
            positiveSide = false;
        }
        else
        {
            positiveSide = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
