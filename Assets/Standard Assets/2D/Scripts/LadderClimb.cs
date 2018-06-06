using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderClimb : MonoBehaviour {

    public float speed = 1;
    private bool pressedE;
    // Use this for initialization
    void Start()
    {

    }
    private void OnTriggerStay2D(Collider2D coll)
    {
        if(Input.GetKeyDown("e"))
        {
            pressedE = true;
        }

        if(coll.tag == "Player" && pressedE)
        {
            coll.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            pressedE = false;
        }
    }
}
