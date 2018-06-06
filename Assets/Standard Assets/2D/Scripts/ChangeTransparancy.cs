using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransparancy : MonoBehaviour {

    // Use this for initialization
    public float alpha = 0.0f;
    int count = 0;
    
	// Update is called once per frame
	void Update () {

            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);

            if (alpha >= 1.0f )
            {
                alpha -= 0.005f;
            }
            else if (alpha <= 1.0f)
            {
                alpha += 0.005f;
            }

        if(alpha >= 1.0f)
        {
            Destroy(GameObject.FindGameObjectWithTag("Fade"));
        }

       
	}
}
