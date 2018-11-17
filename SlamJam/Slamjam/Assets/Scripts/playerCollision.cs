using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player 1" || other.gameObject.tag == "Player 2")
        {
            Destroy(gameObject);
            if (other.GetComponent<PlayerPolarity>().positiveSide == true)
            {
                other.GetComponent<PlayerPolarity>().positiveSide = false;
            }
            else
            {
                other.GetComponent<PlayerPolarity>().positiveSide = true;
            }
        }
    }
}
