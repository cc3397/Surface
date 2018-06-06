using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    // Use this for initialization
    private bool introPlayed;
    private int index;
    private int textLineIndex;
    public Text text;
    public Font font;
    private List<string> introLines = new List<string>();
    public string introLine1, introLine2, introLine3, introLine4;
    public string currentLine;
    GameObject textRend;
    private AudioSource audioToPlay;

    private GameObject textBox;
    Vector3 textBoxPos = new Vector3();
    public bool canControl;
   

    void Start () {
        introLines.Add(introLine1);
        introLines.Add(introLine2);
        introLines.Add(introLine3);
        introLines.Add(introLine4);

        introPlayed = false;

        textRend = new GameObject("myText");
        textRend.transform.SetParent(this.transform);

        textRend.AddComponent<Text>();

        audioToPlay = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();

        textBox = GameObject.FindGameObjectWithTag("Dialouge");

        textBoxPos = textBox.transform.position; //original textbox position

        
    }

    // Update is called once per frame
    void Update() {
        if (!introPlayed)
        {
            
            if (textLineIndex <= introLines.Count - 1)
            {
                currentLine = introLines[textLineIndex];
                audioToPlay.Play();

                if(Input.GetKeyDown("space"))
                {
                    textLineIndex++;
                }
            }
            else if (textLineIndex > introLines.Count - 1)
            {
                introPlayed = true;
                CloseBox();
            }
         }
        else
        {
            if (currentLine != "")
            {
                textBox.transform.position = textBoxPos;
                //disbale user controls
                canControl = false;
                if(Input.GetKeyDown("space"))
                {
                    CloseBox();
                }
            }
        }

		text.text = currentLine;
	}

    private void CloseBox()
    {
        currentLine = "";
        textBox.transform.position = new Vector3(textBox.transform.position.x, textBox.transform.position.y, textBox.transform.position.z - 100);
        canControl = true;
    }

    public void CustomLine(string line)
    {
        currentLine = line;
    }
}
