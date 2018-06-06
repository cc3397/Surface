using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankScript : MonoBehaviour {

    // Use this for initialization
    private GameObject plank;
	void Start () {

        plank = this.gameObject;
	}
	
	// Update is called once per frame

    void Update()
    {

        if (Input.GetKey("e"))
        {
            Debug.Log("E pressed");
            plank.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        else
        {
            plank.GetComponent<BoxCollider2D>().isTrigger = false;
        }


    }
}

