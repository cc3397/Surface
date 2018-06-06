using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInfo : MonoBehaviour {

    private TextControl printText;
    public Canvas canvas;
    public string text;
    private bool used;
    private bool guiShow;
    private Camera cam;

    public bool showImage;

    public Texture img;
    public int imageHeight = 100;
    public int imageWidth = 100;
	// Use this for initialization
	void Start () {
        cam = Camera.main;
        printText = canvas.GetComponent<TextControl>();
	}

    void OnTriggerStay2D(Collider2D coll)
    {
        if (showImage)
        {
            guiShow = true;
        }
        if (!used)
        {
            if (coll.gameObject.tag == "Player")
            {
                Debug.Log("Collision Happnin");

                if (Input.GetKeyDown("e"))
                {
                    printText.CustomLine(text);
                    used = true;
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            guiShow = false;
        }
    }

    private void OnGUI()
    {
        if (guiShow)
        {
            GUI.DrawTexture(new Rect(cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("Player").transform.position).x, (cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("Player").transform.position).y - 160), imageHeight, imageWidth), img);
        }
    }

}
