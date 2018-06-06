using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionText : MonoBehaviour {

    // Use this for initialization
    public string text;
    public Texture img;
    private bool guiShow;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") //if in room then stop cam movement
        {  
            guiShow = true;
        }
    }

    private void Update()
    {
        if (guiShow)
        {
            if (Input.GetKeyDown("space"))
            {
                Destroy(this.gameObject);
                Debug.Log("Space");
            }
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") //if in room then stop cam movement
        {
            guiShow = false;
        }
    }

    private void OnGUI()
    {
        if (guiShow)
        {
            GUI.DrawTexture(new Rect((Screen.width / 2), ((Screen.height / 2) - 150), 50, 50), img);
        }
    }
}
