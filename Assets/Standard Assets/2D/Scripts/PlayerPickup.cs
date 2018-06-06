using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour {

    // Use this for initialization
    public Texture img;
    private bool guiShow;
    private PickupItem item;
    private item itemToPickup;
    private GameObject itemToDestroy;
    private TextControl printText;
    private bool bagPickup;
    private bool isBag;
    private string textToDisplay;
    public Canvas canvas;
    private AudioSource audioSource;
    private bool locket;
    Camera cam;

    public int imageHeight = 100;
    public int imageWidth = 100;
    private TorchController torch;
    void Start()
    {
        cam = Camera.main;
        bagPickup = false;
        locket = false;

        printText = canvas.GetComponent<TextControl>();

        audioSource = this.gameObject.GetComponent<AudioSource>();

        torch = this.gameObject.GetComponent<TorchController>();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.tag == "Pickup") 
        {
            guiShow = true;
            item = coll.gameObject.GetComponent<PickupItem>();
            itemToPickup = item.Item();
            textToDisplay = item.TextToDisplay();
            itemToDestroy = coll.gameObject; //recognize which GO we are at

            if(itemToPickup == global::item.Bag)
            {
                isBag = true;
            }
            else
            {
                isBag = false;
            }
        }
    }

    private void Update()
    {
        if (guiShow)
        {
            if (isBag || bagPickup)
            {
                if (Input.GetKeyDown("e"))
                {
                    Destroy(itemToDestroy);
                    printText.CustomLine(textToDisplay);
                    bagPickup = true;
                    audioSource.Play();
                }
            }
            else
            {
                if (Input.GetKeyDown("e"))
                {
                    printText.CustomLine("I should find my bag first!");
                    audioSource.Play();
                }
            }
            if (!locket)
            {
                if (itemToPickup == global::item.Locket)
                {
                    if (Input.GetKeyDown("e"))
                    {
                        Destroy(itemToDestroy);
                        printText.CustomLine(textToDisplay);
                        bagPickup = true;
                        audioSource.Play();
                        locket = true;
                    }
                }

                if (itemToPickup == global::item.Torch)
                {
                    if (Input.GetKeyDown("e"))
                    {
                        torch.EnableTorch();
                    }
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Pickup") //if in room then stop cam movement
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
