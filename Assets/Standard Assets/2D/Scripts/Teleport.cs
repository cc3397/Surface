using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    private GameObject blackOut;
    private bool used = false;
    public Vector3 teleportLocation;
    public float timer = 5.0f;
    void Start()
    {
        blackOut = Resources.Load("BlackOut") as GameObject;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (!used)
        {
            if (coll.tag == "Player")
            {
                Instantiate(blackOut);
                used = true;
            }
        }

       
    }

    private void Update()
    {

        if(used)
        {
            timer -= Time.deltaTime;

            if(timer <= 0)
            {
                GameObject.FindGameObjectWithTag("Player").transform.position = teleportLocation;
                used = false;
            }
        }
    }
}
