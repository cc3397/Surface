using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour {

    // Use this for initialization
    public Light playerLight;
    private bool isLit;
    private float duration = 1.0f;
    public float timer = 3.0f;
	void Start () {

        playerLight.intensity = 4.0f;
	}
	
	// Update is called once per frame
	void Update () {

        if(!isLit)
        {
            return;
        }
        else if (isLit)
        {
            timer -= Time.deltaTime;

            if (timer <= 0.0f)
            {
                playerLight.intensity = Random.Range(4.0f, 6.0f);
                timer = Random.Range(0.0f, 1.0f);
            }

        }
		
	}
    public void EnableTorch()
    {
        isLit = true;
    }
}
