using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteOut : MonoBehaviour {

    // Use this for initialization
    private GameObject whiteOut;
    private bool used = false;
	void Start () {
        whiteOut = Resources.Load("WhiteOut") as GameObject;
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (!used)
        {
            if (coll.tag == "Player")
            {
                Instantiate(whiteOut);
            }
        }
    }
	
	// Update is called once per frame
	
}
