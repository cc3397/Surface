using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public bool camMove;
    public Transform lookAt;
    public float offsetZ;
    private Transform camPos;
    private float yPos;
    private float yPosnew;

    
    // Use this for initialization
    void Start()
    {
        camPos = this.transform;

        yPos = this.transform.position.y;
        yPosnew = this.transform.position.y;
        //camMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        yPos = lookAt.position.y;

        if(yPos > (yPosnew + 0.1) || yPos < (yPosnew - 0.1))
           {
            yPos = lookAt.transform.position.y;
            yPosnew = yPos;
           }

        if (camMove)
        {
            camPos.position = new Vector3(lookAt.position.x, yPosnew + 0.8f , lookAt.position.z - offsetZ);

            this.transform.position = camPos.position;
        }
        else if (!camMove)
        {
            camPos.position = camPos.position;
        }
    }
}